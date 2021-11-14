using System.Collections.Immutable;
using System.Diagnostics.Metrics;

namespace workspace.Utils
{
	public class AdventUtils
	{
		public static (int, int) TwoSum(int target, ImmutableHashSet<int> set)
		{
			foreach (var s in set)
			{
				var diff = target - s;
				if (set.Contains(diff))
				{
					return (s, diff);
				}
			}

			return default;
		}

		public static (int, int, int) ThreeSum(int target, ImmutableHashSet<int> set)
		{
			foreach (var s in set)
			{
				var diff = target - s;
				var newSet = set.Except(new[] { s });
				var twoSum = TwoSum(diff, newSet);
				if (twoSum != default)
				{
					return (s, twoSum.Item1, twoSum.Item2);
				}
			}

			return default;
		}
	}

	public static class TupleExtensions
	{
		public static int Product(this (int, int) tuple)
		{
			return tuple.Item1 * tuple.Item2;
		}

		public static int Product(this (int, int, int) tuple)
		{
			return tuple.Item1 * tuple.Item2 * tuple.Item3;
		}
	}

}