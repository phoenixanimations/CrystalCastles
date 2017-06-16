using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrystalCastles;

namespace CrystalCastlesDebug
{
	public class VectorDebug
	{
		/// <summary>
		/// Converts the Crystal Castles engine's VectorCreature to Up, Down, Left, Right, to string.
		/// </summary>
		/// <returns>Returns Up, Down, Left, Right</returns>
		/// <param name="vectorToConvert">Insert a VectureCreature variable.</param>
		/// Note: This isn't a switch statement as vectors aren't supported by switch statements.
		public static string VectorCreatureToText (Vector2 vectorToConvert)
		{
			string vectorString = "Not a VectorCreature Vector.";
			if (vectorToConvert == VectorCreature.Up)
				vectorString =  "Up";
			if (vectorToConvert == VectorCreature.Down)
				vectorString =  "Down";
			if (vectorToConvert == VectorCreature.Left)
				vectorString =  "Left";
			if (vectorToConvert == VectorCreature.Right)
				vectorString =  "Right";
			return vectorString;
		}
	}
}