using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrystalCastles.Variable
{
	public sealed class Arrow 
	{
		static public readonly string Up = '\u2191'.ToString();
		static public readonly string RightUp = '\u2197'.ToString();
		static public readonly string Right = '\u2192'.ToString();
		static public readonly string RightDown = '\u2198'.ToString();
		static public readonly string Down = '\u2193'.ToString();
		static public readonly string LeftDown = '\u2199'.ToString();
		static public readonly string Left = '\u2190'.ToString();
		static public readonly string LeftUp = '\u2196'.ToString();
	}

	public sealed class Shape
	{
		static public readonly string Diamond = '\u2666'.ToString();
		static public readonly string Cross = '\u271C'.ToString();
	}
}