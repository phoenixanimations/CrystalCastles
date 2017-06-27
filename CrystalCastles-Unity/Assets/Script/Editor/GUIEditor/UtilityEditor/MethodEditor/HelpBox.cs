using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace CrystalCastles.UnityEditor
{
	public static class HelpBox
	{
		public static string ComponentError (string componentName)
		{
			return componentName + " is null. This will cause errors with the code. " +
				"Please drag the " + componentName + " component to the box and then hit apply.";
		}		
	}
}
