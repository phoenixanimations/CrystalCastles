﻿using UnityEngine;
using System.Collections;
using CrystalCastles.Mouse;

namespace UnityExample
{
	public class UnityCursorExample : MonoBehaviour
	{
		CursorLockMode wantedMode;
	
		// Apply requested cursor state
		void SetCursorState ()
		{
			Cursor.lockState = wantedMode;
			// Hide cursor when locking
			Cursor.visible = (CursorLockMode.Locked != wantedMode);
		}

		void Update ()
		{
//			Debug.Log("x: " + Input.GetAxis(GetAxis.xMouse) + " | " + "y: " + Input.GetAxis(GetAxis.yMouse));
		}

		void OnGUI ()
		{
			GUILayout.BeginVertical ();
			// Release cursor on escape keypress
			if (Input.GetKeyDown (KeyCode.Escape))
				Cursor.lockState = wantedMode = CursorLockMode.None;
	
			switch (Cursor.lockState) {
			case CursorLockMode.None:
				GUILayout.Label ("Cursor is normal");
				if (GUILayout.Button ("Lock cursor"))
					wantedMode = CursorLockMode.Locked;
				if (GUILayout.Button ("Confine cursor"))
					wantedMode = CursorLockMode.Confined;
				break;
			case CursorLockMode.Confined:
				GUILayout.Label ("Cursor is confined");
				if (GUILayout.Button ("Lock cursor"))
					wantedMode = CursorLockMode.Locked;
				if (GUILayout.Button ("Release cursor"))
					wantedMode = CursorLockMode.None;
				break;
			case CursorLockMode.Locked:
				GUILayout.Label ("Cursor is locked");
				if (GUILayout.Button ("Unlock cursor"))
					wantedMode = CursorLockMode.None;
				if (GUILayout.Button ("Confine cursor"))
					wantedMode = CursorLockMode.Confined;
				break;
			}
	
			GUILayout.EndVertical ();
	
			SetCursorState ();
		}
	}
}