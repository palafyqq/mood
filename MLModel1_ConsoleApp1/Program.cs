﻿
// This file was auto-generated by ML.NET Model Builder. 

using MLModel1_ConsoleApp1;

// Create single instance of sample data from first line of dataset for model input
MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
{
    Text = @"Oh dear an evening of absolute hilarity I don't think I have laughed so much in a long time! 😂",
};

// Make a single prediction on the sample data and print results
var predictionResult = MLModel1.Predict(sampleData);

Console.WriteLine("Using model to make single prediction -- Comparing actual Label with predicted Label from sample data...\n\n");


Console.WriteLine($"Text: {@"Oh dear an evening of absolute hilarity I don't think I have laughed so much in a long time! 😂"}");
Console.WriteLine($"Label: {@"joy"}");


Console.WriteLine($"\n\nPredicted Label: {predictionResult.PredictedLabel}\n\n");
Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();
