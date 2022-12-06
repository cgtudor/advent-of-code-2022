// See https://aka.ms/new-console-template for more information

var lines = File.ReadAllLines(@"C:\\source\\advent-of-code-2022\\advent-of-code-2022\\day-1\\day1_input.txt");
var maxCalories = 0;
var currentElfCalories = 0;

//Console.WriteLine("Contents of day1 input: ");
foreach(var line in lines) {
    //Console.WriteLine(line);
    if (line.Length == 0)
    {
        maxCalories = currentElfCalories > maxCalories ? currentElfCalories : maxCalories;
        currentElfCalories = 0;
        continue;
    }
    currentElfCalories += int.Parse(line);
}

maxCalories = currentElfCalories > maxCalories ? currentElfCalories : maxCalories;
Console.WriteLine("Most calories carried: " + maxCalories);