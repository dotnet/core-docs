open System
open System.IO
open Azure.Storage.Blobs // Namespace for Blob storage types
open Azure.Storage.Blobs.Models
open Azure.Storage.Blobs.Specialized
open System.Text
open System.Collections.Generic

//
// Get your connection string.
//

let storageConnString = "..." // fill this in from your storage account
(*
// Parse the connection string and return a reference to the storage account.
let storageConnString = 
    CloudConfigurationManager.GetSetting("StorageConnectionString")
*)

//
// Create some local dummy data.
//

// Create a dummy file to upload
let localFile = __SOURCE_DIRECTORY__ + "/myfile.txt"
File.WriteAllText(localFile, "some data")

//
// Create the blob service client.
//

let service = new BlobServiceClient(storageConnString);

//
// Create a container.
//

 // Retrieve a reference to a container.
let container = service.GetBlobContainerClient("myContainer");

// Create the container if it doesn't already exist.
container.CreateIfNotExists()

let permissions = PublicAccessType.Blob
container.SetAccessPolicy(permissions)

//
// Upload a blob into a container.
//

// Retrieve reference to a blob named "myblob.txt".
let blockBlob = container.GetBlockBlobClient("myblob.txt")

// Create or overwrite the "myblob.txt" blob with contents from the local file.
let fileStream = new FileStream(localFile, FileMode.Open, FileAccess.Read, FileShare.Read)
let offset = 0
let length = int(fileStream.Length)
let bytes = Array.zeroCreate<byte>(length)
fileStream.Read(bytes, offset, bytes.Length)
fileStream.Close();
let stream = new MemoryStream(bytes)
do blockBlob.Upload(stream)

//
// List the blobs in a container.
//

// Loop over items within the container and output the name.
for item in container.GetBlobs() do
    printfn "Blob name: %s" item.Name 

//
// Download Blobs.
//

// Retrieve reference to a blob named "myblob.txt".
let blobToDownload = container.GetBlobClient("myblob.txt")

// Save blob contents to a file.
do
    use fileStream = File.OpenWrite(__SOURCE_DIRECTORY__ + "/path/download.txt")
    blobToDownload.DownloadTo(fileStream)

let text =
    use memoryStream = new MemoryStream()
    blobToDownload.DownloadTo(memoryStream)
    Text.Encoding.UTF8.GetString(memoryStream.ToArray())

//
// Delete blobs.
//

// Retrieve reference to a blob named "myblob.txt".
let blobToDelete = container.GetBlobClient("myblob.txt")

// Delete the blob.
blobToDelete.Delete()

//
// List blobs in pages asynchronously
//

let ListBlobsSegmentedInFlatListing(container:BlobContainerClient) =
    async {

        // List blobs to the console window, with paging.
        printfn "List blobs in pages:"

        // Call ListBlobsSegmentedAsync and enumerate the result segment
        // returned, while the continuation token is non-null.
        // When the continuation token is null, the last page has been 
        // returned and execution can exit the loop.

        let blobs = new List<BlobItem>()

        for page in container.GetBlobs().AsPages() do
            blobs.AddRange(page.Values)

        for blobItem in blobs do 
            printf "The BlobItem is : %s " blobItem.Name
        printfn ""

    }

// Create some dummy data by uploading the same file over and over again
for i in 1 .. 100 do
    let blob  = container.GetBlobClient("myblob" + string i + ".txt")
    use fileStream = System.IO.File.OpenRead(localFile)
    blob.Upload(localFile)

ListBlobsSegmentedInFlatListing container |> Async.RunSynchronously

//
// Writing to an append blob.
//

// Get a reference to a container.
let appendContainer = service.GetBlobContainerClient("my-append-blobs")

// Create the container if it does not already exist.
appendContainer.CreateIfNotExists() |> ignore

// Get a reference to an append blob.
let appendBlob = appendContainer.GetAppendBlobClient("append-blob.log")

// Create the append blob. Note that if the blob already exists, the 
// CreateOrReplace() method will overwrite it. You can check whether the 
// blob exists to avoid overwriting it by using CloudAppendBlob.Exists().
appendBlob.CreateIfNotExists()

let numBlocks = 10

// Generate an array of random bytes.
let rnd = new Random()
let bytesArray = Array.zeroCreate<byte>(numBlocks)
rnd.NextBytes(bytesArray)

// Simulate a logging operation by writing text data and byte data to the 
// end of the append blob.
for i in 0 .. numBlocks - 1 do
    let msg = sprintf "Timestamp: %A \tLog Entry: %d\n" DateTime.UtcNow bytesArray.[i]
    let array = Encoding.ASCII.GetBytes(msg);
    let stream = new MemoryStream(array)
    appendBlob.AppendBlock(stream)

// Read the append blob to the console window.
let downloadedText = appendBlob.DownloadContent().ToString()
printfn "%s" downloadedText
