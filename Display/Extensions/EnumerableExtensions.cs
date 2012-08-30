using System.Collections.Generic;
using System.Linq;

namespace Display.Extensions
{
	public static class EnumerableExtensions
	{
		public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> seq)
		{
			return seq ?? Enumerable.Empty<T>();
		}
	}
}