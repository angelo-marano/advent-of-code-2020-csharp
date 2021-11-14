using workspace.Problems;

var dayOneSolution = await DayOne.Solve();
Console.WriteLine($"The solution for the first section of day one is: {dayOneSolution.Item1}");
Console.WriteLine($"The solution for the second section of day one is: {dayOneSolution.Item2}");

var dayTwoSolution = await DayTwo.Solve();
Console.WriteLine($"The solution for the first section day two is {dayTwoSolution.Item1}");
Console.WriteLine($"The solution for the second section of day two is {dayTwoSolution.Item2}");