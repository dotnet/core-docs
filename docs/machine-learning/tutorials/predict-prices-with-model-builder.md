---
title: 'Predict prices using regression with Model Builder'
description: This tutorial illustrates how to build a regression model using ML.NET Model Builder to predict prices, specifically, New York City taxi fares.
author: luisquintanilla
ms.author: luquinta
ms.date: 06/26/2019
ms.topic: tutorial
ms.custom: mvc
#Customer intent: As a non-developer, I want to use Model Builder to automatically generate a model to predict prices using Model Builder. 
---

# Predict prices using regression with Model Builder

Learn how to use ML.NET Model Builder to build a [regression model](../resources/glossary.md#regression) to predict prices.  The .NET console app that you develop in this tutorial predicts taxi fares based on historical New York taxi fare data.

The Model Builder price prediction template can be used for any scenario requiring a numerical prediction value. Example scenarios include: house price prediction, demand prediction, and sales forecasting.

In this tutorial, you learn how to:
> [!div class="checklist"]
> * Prepare and understand the data
> * Choose a scenario
> * Load the data
> * Train the model
> * Evaluate the model
> * Use the model for predictions

> [!NOTE]
> Model Builder is currently in Preview.

## Pre-requisites

For a list of pre-requisites and installation instructions, visit the [Model Builder installation guide](../how-to-guides/install-model-builder.md).

## Create a console application

1. Create a **.NET Core Console Application** called "TaxiFarePrediction".

1. Install the **Microsoft.ML** NuGet Package:

    In **Solution Explorer**, right-click the *TaxiFarePrediction* project and select **Manage NuGet Packages**. Choose "nuget.org" as the Package source, select the **Browse** tab, search for **Microsoft.ML**, select the package in the list, and select the **Install** button. Select the **OK** button on the **Preview Changes** dialog and then select the **I Accept** button on the **License Acceptance** dialog if you agree with the license terms for the packages listed.

## Prepare and understand the data

1. Create a directory named *Data* in your project to store the data set files.

1. Download the [taxi-fare-train.csv](https://github.com/dotnet/machinelearning/blob/master/test/data/taxi-fare-train.csv) data set and save it to the *Data* folder you created at the previous step. This data set is used to train and evaluate the machine learning model. This data set is originally from the [NYC TLC Taxi Trip data set](http://www.nyc.gov/html/tlc/html/about/trip_record_data.shtml).

1. In **Solution Explorer**, right-click the *taxi-fare-train.csv* file and select **Properties**. Under **Advanced**, change the value of **Copy to Output Directory** to **Copy if newer**.

Each row in the `taxi-fare-train.csv` data set contains details of trips made by a taxi. 

1. Open the **taxi-fare-train.csv** data set

    The provided data set contains the following columns:

    * **vendor_id:** The ID of the taxi vendor is a feature.
    * **rate_code:** The rate type of the taxi trip is a feature.
    * **passenger_count:** The number of passengers on the trip is a feature.
    * **trip_time_in_secs:** The amount of time the trip took. You want to predict the fare of the trip before the trip is completed. At that moment you don't know how long the trip would take. Thus, the trip time is not a feature and you'll exclude this column from the model.
    * **trip_distance:** The distance of the trip is a feature.
    * **payment_type:** The payment method (cash or credit card) is a feature.
    * **fare_amount:** The total taxi fare paid is the label.

The `label` is the column you want to predict. When performing a regression task, the goal is to predict a numerical value. In this price prediction scenario, the cost of a taxi ride is being predicted. Therefore, the **fare_amount** is the label. The identified `features` are the inputs you give the model to predict the `label`. In this case, the rest of the columns are used as features or inputs to predict the fare amount.

## Choose a scenario

To train your model, you need to select from the list of available machine learning scenarios provided by Model Builder. In this case, the scenario is `Price Prediction`. For a more extensive list visit the [Model Builder overview article](../automate-training-with-model-builder.md#scenarios).

1. In **Solution Explorer**, right-click the *TaxiFarePrediction* project, and select **Add** > **Machine Learning**.
1. In the scenario step of the Model Builder tool, select *Price Prediction* scenario.

## Load the data

Model Builder accepts data from two sources, a SQL Server database or a local file csv or tsv file. For more information on data format requirements, visit the following [link](../how-to-guides/install-model-builder.md#limitations).

1. In the data step of the Model Builder tool, select *File* from the data source dropdown.
1. Select the button next to the *Select a file* text box and use File Explorer to browse and select the *taxi-fare-test.csv* in the *Data* directory
1. Choose *fare_amount* in the *Label or Column to Predict* dropdown and navigate to the train step of the Model Builder tool.

## Train the model

The machine learning task used to train the price prediction model in this tutorial is regression. During the model training process, Model Builder trains separate models using different regression algorithms and settings to find the best performing model for your dataset.

The time required for the model to train is proportionate to the amount of data. Use this chart as guidance to select an adequate value for the `Time to train (seconds)` field:

*Dataset Size  | Dataset Type       | Avg. Time to train*
------------- | ------------------ | --------------
0 - 10 Mb     | Numeric and Text   | 10 sec
10 - 100 Mb   | Numeric and Text   | 10 min
100 - 500 Mb  | Numeric and Text   | 30 min
500 - 1 Gb    | Numeric and Text   | 60 min
1 Gb+         | Numeric and Text   | 3 hour+

1. Because the training data file is more than 10MB, use 600 seconds (10 minutes) as the value for *Time to train (seconds)*.
2. Select *Start Training*.

Throughout the training process, progress data is displayed in the `Progress` section of the train step.

- Status displays the completion status of the training process.
- Best accuracy displays the accuracy of the best performing model found by Model Builder so far. Higher accuracy means the model predicted more correctly on test data. 
- Best algorithm displays the name of the best performing algorithm performed found by Model Builder so far.
- Last algorithm displays the name of the algorithm most recently used by Model Builder to train the model.

Once training is complete, navigate to the evaluate step.

## Evaluate the model

The result of the training step will be one model which had the best performance. In the evaluate step of the Model Builder tool, the output section, will contain the algorithm used by the best performing model in the *Best Model* entry along with metrics in *Best Model Quality (RSquared)*. Additionally, a summary table containing top five models and their metrics. Visit the following link to learn more about [evaluating model metrics](https://docs.microsoft.com/dotnet/machine-learning/resources/metrics).

If you're not satisfied with your accuracy metrics, some easy ways to try and improve model accuracy are to increase the amount of time to train the model or use more data.

## Use the model for predictions

Two projects will be created as a result of the training process.

- TaxiFarePredictionML.ConsoleApp: A .NET Console application that contains the model training and consumption code.
- TaxiFarePredictionML.Model: A .NET Standard class library containing the data models that define the schema of input and output model data as well as the persisted version of the best performing model during training.

1. In the code section of the Model Builder tool, select **Added Projects** to add the projects to the solution.
1. In solution explorer, right-click the *TaxiFarePrediction* project. Then, select **Add > Existing Item**. For file type drop down, select `All Files`, navigate to the *TaxiFarePredictionML.Model* project directory and select the `MLModel.zip` file. Then right-click the recently added `MLModel.zip` file and select *Properties*. For the Copy to Output Directory option, select *Copy if Newer* from the dropdown.
1. Right-click *TaxiFarePrediction* project. Then, **Add > Reference**. Choose the **Projects > Solution** node and from the list, check the *TaxiFarePredictionML.Model* project and select OK.

4. Open the *Program.cs* file in the *TaxiFarePrediction* project.
5. Add the following using statements:

    ```csharp
    using System;
    using Microsoft.ML;
    using TaxiFarePredictionML.Model.DataModels;
    ```

6. Add the `ConsumeModel` method to the `Program` class. The `ConsumeModel` will create a `PredictionEngine` based on the model generated by Model Builder to make predictions on new data and print them out to the console.

    ```csharp
    static ModelOutput ConsumeModel(ModelInput input)
    {
        // 1. Load the model
        MLContext mlContext = new MLContext();
        ITransformer mlModel = mlContext.Model.Load("MLModel.zip", out var modelInputSchema);

        // 2. Create PredictionEngine
        var predictionEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);

        // 3. Use PredictionEngine to use model on input data
        ModelOutput result = predictionEngine.Predict(input);

        // 4. Return prediction result
        return result;
    }
    ```

7. Add the following code to the `Main` method and run the application.

    ```csharp
    // Create sample data
    ModelInput input = new ModelInput()
    {
        Vendor_id = "CMT",
        Rate_code = 1,
        Passenger_count = 1,
        Trip_time_in_secs = 1271,
        Trip_distance = 3.8f,
        Payment_type = "CRD"
    };

    // Make prediction
    ModelOutput prediction = ConsumeModel(input);

    // Print Prediction
    Console.WriteLine($"Predicted Fare: {prediction.Score}");
    Console.ReadKey();
    ```

    The output generated by the program should look similar to the snippet below:

    ```bash
    Predicted Fare: 16.82245
    ```

If you need to reference the generated projects at a later time inside of another solution, you can find them inside the `C:\Users\%USERNAME%\AppData\Local\Temp\MLVSTools` directory.

## Next Steps

In this tutorial, you learned how to:
> [!div class="checklist"]
> * Prepare and understand the data
> * Choose a scenario
> * Load the data
> * Train the model
> * Evaluate the model
> * Use the model for predictions

Advance to either of the following how-to articles to learn how to deploy your model.

> [!div class="nextstepaction"]
> [Deploy a model to Azure Functions](../how-to-guides/serve-model-serverless-azure-functions-ml-net.md)
> [!div class="nextstepaction"]
> [Deploy a model to a Web API](../how-to-guides/serve-model-web-api-ml-net.md)
