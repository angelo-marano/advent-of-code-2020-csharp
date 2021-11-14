using System.Reflection;

namespace workspace.Utils
{
	public class PasswordPolicyReader
	{
		public static Lazy<Task<IEnumerable<PasswordPolicy>>> PasswordPolicies = new(async () =>
		{
			var assembly = Assembly.GetExecutingAssembly();
			var resourceName = "workspace.Problems.day_two_input.txt";

			using var stream = assembly.GetManifestResourceStream(resourceName);
			using var reader = new StreamReader(stream);
			var values = new List<PasswordPolicy>();
			while (!reader.EndOfStream)
			{
				var line = await reader.ReadLineAsync();
				var policy = new PasswordPolicy(line);
				values.Add(policy);
			}

			return values;
		});
	}
}