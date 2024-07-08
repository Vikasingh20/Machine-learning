﻿
// This file was auto-generated by ML.NET Model Builder. 

using PredictiveMaintenanceModel_ConsoleApp1;

// Create single instance of sample data from first line of dataset for model input
PredictiveMaintenanceModel.ModelInput sampleData = new PredictiveMaintenanceModel.ModelInput()
{
    //Data for which we want to predict.
    SQUARE_FT = 879.1208791000001F,
    ADDRESS = @"Chromepet,Chennai",
};



Console.WriteLine("Using model to make single prediction -- Comparing actual TARGET_PRICE_IN_LACS_ with predicted TARGET_PRICE_IN_LACS_ from sample data...\n\n");


Console.WriteLine($"SQUARE_FT: {1275F}");
Console.WriteLine($"ADDRESS: {@"Vishweshwara Nagar,Mysore"}");
Console.WriteLine($"TARGET_PRICE_IN_LACS_: {51F}");


var predictionResult = PredictiveMaintenanceModel.Predict(sampleData);
Console.WriteLine($"\n\nPredicted TARGET_PRICE_IN_LACS_: {predictionResult.Score}\n\n");

Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();

