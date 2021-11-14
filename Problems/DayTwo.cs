using workspace.Utils;

namespace workspace.Problems
{
	public class DayTwo
	{
		public static async Task<(int, int)> Solve()
		{
			var policies = await PasswordPolicyReader.PasswordPolicies.Value;
			return (policies.Count(x => x.IsValid), policies.Count(x => x.IsValidForAdvancedRules));
		}
	}
}