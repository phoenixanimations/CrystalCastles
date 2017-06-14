using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CrystalCastles
{
	public static class MoreLinq
	{
		/// <summary>
		/// Multiplies each item in the list. Example: {3, 2, 4} would return 24.
		/// </summary>
		/// <param name="list">List to Multiple</param>
		public static float Multiple (this List<float> list)
		{
			return list.Aggregate ((current, total) => current * total);
		}

		/// <summary>
		/// Sets all variables to 0. Example: {3, 2, 4} would return {0, 0, 0}.
		/// </summary>
		/// <param name="list">List to Set</param>
		public static List <float> Zero (this List<float> list)
		{
			return list.Select (z => z = 0f).ToList ();
		}

		/// <summary>
		/// Sets all variables to 1. Example: {3, 2, 4} would return {1, 1, 1}.
		/// </summary>
		/// <param name="list">List.</param>
		public static List <float> One (this List<float> list)
		{
			return list.Select (z => z = 1f).ToList ();
		}
	}
}