//Load sample data
using ConsoleApp2;

string text =Console.ReadLine();

var sampleData = new MLModel1.ModelInput()
{
    Text = @"Oh dear an evening of absolute hilarity I don't think I have laughed so much in a long time! 😂",
};
sampleData.Text = text;

//Load model and predict output
var result = MLModel1.Predict(sampleData);
var mood = result.PredictedLabel;
Console.WriteLine($"Предположительное настроение: {mood} ");