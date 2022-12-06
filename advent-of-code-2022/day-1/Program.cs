// See https://aka.ms/new-console-template for more information

var lines = File.ReadAllLines(@"C:\\source\\advent-of-code-2022\\advent-of-code-2022\\day-1\\day1_input.txt");
var allElvesCalories = new List<int>();

var maxCalories = 0;
var currentElfCalories = 0;

//Console.WriteLine("Contents of day1 input: ");
foreach(var line in lines) {
    //Console.WriteLine(line);
    if (line.Length == 0)
    {
        allElvesCalories.Add(currentElfCalories);
        currentElfCalories = 0;
        continue;
    }
    currentElfCalories += int.Parse(line);
}
allElvesCalories.Add(currentElfCalories);
var descendingElvesCalories = allElvesCalories.OrderByDescending(x => x).ToList();

Console.WriteLine("Most calories carried: " + descendingElvesCalories[0]);

var sumOfTopThree = descendingElvesCalories[0] + descendingElvesCalories[1] + descendingElvesCalories[2];
Console.WriteLine("Sum of top 3 calories carried: " + sumOfTopThree);
