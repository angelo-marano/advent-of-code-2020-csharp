using workspace.Utils;
using static workspace.Utils.AdventUtils;

namespace workspace.Problems
{
	public class DayOne
	{
		public static async Task<(int, int)> Solve()
		{
			var expenses = await ExpenseReportReader.Expenses.Value;
			var twoSum = TwoSum(2020, expenses);
			var threeSum = ThreeSum(2020, expenses);
			return (twoSum.Product(), threeSum.Product());
		}
	}
}