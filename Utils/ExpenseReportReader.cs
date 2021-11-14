using System.Collections.Immutable;
using System.Reflection;

namespace workspace.Utils
{
	public class ExpenseReportReader
	{
		public static Lazy<Task<ImmutableHashSet<int>>> Expenses = new(async () =>
		{
			var assembly = Assembly.GetExecutingAssembly();
			var resourceName = "workspace.Problems.day_one_input.txt";

			using var stream = assembly.GetManifestResourceStream(resourceName);
			using var reader = new StreamReader(stream);
			var values = new List<int>();
			while (!reader.EndOfStream)
			{
				var line = await reader.ReadLineAsync();
				values.Add(int.Parse(line));
			}

			return values.ToImmutableHashSet();
		});
	}
}