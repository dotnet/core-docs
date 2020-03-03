// The following code example demonstrates several of the properties and methods of StringDictionary.
// <snippet1>
#using <System.dll>

using namespace System;
using namespace System::Collections;
using namespace System::Collections::Specialized;
void PrintKeysAndValues2( StringDictionary^ myCol );
void PrintKeysAndValues3( StringDictionary^ myCol );

int main()
{
   // Creates and initializes a new StringDictionary.
   StringDictionary^ myCol = gcnew StringDictionary;
   myCol->Add( "red", "rojo" );
   myCol->Add( "green", "verde" );
   myCol->Add( "blue", "azul" );

   // Display the contents of the collection using the enumerator.
   Console::WriteLine( "Displays the elements using the IEnumerator:" );
   PrintKeysAndValues2( myCol );

   // Display the contents of the collection using the Keys, Values, Count, and Item properties.
   Console::WriteLine( "Displays the elements using the Keys, Values, Count, and Item properties:" );
   PrintKeysAndValues3( myCol );

   // Copies the StringDictionary to an array with DictionaryEntry elements.
   array<DictionaryEntry>^myArr = gcnew array<DictionaryEntry>(myCol->Count);
   myCol->CopyTo( myArr, 0 );

   // Displays the values in the array.
   Console::WriteLine( "Displays the elements in the array:" );
   Console::WriteLine( "   KEY        VALUE" );
   for ( int i = 0; i < myArr->Length; i++ )
      Console::WriteLine( "   {0,-10} {1}", myArr[ i ].Key, myArr[ i ].Value );
   Console::WriteLine();

   // Searches for a value.
   if ( myCol->ContainsValue( "amarillo" ) )
      Console::WriteLine( "The collection contains the value \"amarillo\"." );
   else
      Console::WriteLine( "The collection does not contain the value \"amarillo\"." );

   Console::WriteLine();
   
   // Searches for a key and deletes it.
   if ( myCol->ContainsKey( "green" ) )
      myCol->Remove( "green" );

   Console::WriteLine( "The collection contains the following elements after removing \"green\":" );
   PrintKeysAndValues2( myCol );

   // Clears the entire collection.
   myCol->Clear();
   Console::WriteLine( "The collection contains the following elements after it is cleared:" );
   PrintKeysAndValues2( myCol );
}

// Uses the enumerator. 
void PrintKeysAndValues2( StringDictionary^ myCol )
{
   IEnumerator^ myEnumerator = myCol->GetEnumerator();
   DictionaryEntry de;
   Console::WriteLine( "   KEY                       VALUE" );
   while ( myEnumerator->MoveNext() )
   {
      de =  *dynamic_cast<DictionaryEntry^>(myEnumerator->Current);
      Console::WriteLine( "   {0,-25} {1}", de.Key, de.Value );
   }

   Console::WriteLine();
}

// Uses the Keys, Values, Count, and Item properties.
void PrintKeysAndValues3( StringDictionary^ myCol )
{
   array<String^>^myKeys = gcnew array<String^>(myCol->Count);
   myCol->Keys->CopyTo( myKeys, 0 );
   Console::WriteLine( "   INDEX KEY                       VALUE" );
   for ( int i = 0; i < myCol->Count; i++ )
      Console::WriteLine( "   {0,-5} {1,-25} {2}", i, myKeys[ i ], myCol[ myKeys[ i ] ] );
   Console::WriteLine();
}

/*
This code produces the following output.

Displays the elements using the IEnumerator:
   KEY                       VALUE
   red                       rojo
   blue                      azul
   green                     verde

Displays the elements using the Keys, Values, Count, and Item properties:
   INDEX KEY                       VALUE
   0     red                       rojo
   1     blue                      azul
   2     green                     verde

Displays the elements in the array:
   KEY        VALUE
   red        rojo
   blue       azul
   green      verde

The collection does not contain the value "amarillo".

The collection contains the following elements after removing "green":
   KEY                       VALUE
   red                       rojo
   blue                      azul

The collection contains the following elements after it is cleared:
   KEY                       VALUE

*/
// </snippet1>
