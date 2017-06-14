using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using CrystalCastles.Variable;

/// So my plan to code the cursor is to treat the cursor like the creature class and it will
/// use all the raycasting features and everything else that the creature class comes with.
/// Example it checks if it can go on the next tile using the same code creature does. If there is a
/// block it will go on top of it, etc, etc. It is for all purposes a creature itself.
namespace CrystalCastles.Mouse
{
	public class GarbageMouseGUI : MonoBehaviour
	{
		public float mouseUpSensitivity;
		public float mouseRightSensitivity;
		public float mouseDownSensitivity;
		public float mouseLeftSensitivity;

		/// <summary>
		/// Sets whether the cursor is locked or not.
		/// </summary>
		bool lockCursor = true;
		
		/// <summary>
		/// Has to be on GUI otherwise the cursor won't act properly. 
		/// </summary>
		void SetCursorState ()
		{
			if (Input.GetKeyDown (KeyCode.Escape))
			{
				lockCursor = false;
			}

			if (lockCursor)
			{
				Cursor.visible = false;			
				Cursor.lockState = CursorLockMode.Locked;
			}
			else
			{
				Cursor.visible = true;
				Cursor.lockState = CursorLockMode.None;
			}
		}

		void MouseAttempt1 ()
		{
			if (Input.GetAxis(GetAxis.yMouse) > mouseUpSensitivity)
			{
				transform.position = (Vector2)transform.position + VectorC.Up;
			}
			
			if (Input.GetAxis(GetAxis.xMouse) > mouseRightSensitivity)
			{
				transform.position = (Vector2)transform.position + VectorC.Right;
			}
			
			if (Input.GetAxis(GetAxis.yMouse) < mouseDownSensitivity)
			{
				transform.position = (Vector2)transform.position + VectorC.Down;
			}

			if (Input.GetAxis(GetAxis.xMouse) < mouseLeftSensitivity )
			{
				transform.position = (Vector2)transform.position + VectorC.Left;
			}			
		}

		void CheckForZero ()
		{
			if (mouseUpSensitivity < 0)
				mouseUpSensitivity = 0;
			
			if (mouseRightSensitivity < 0)
				mouseRightSensitivity = 0;
			
			if (mouseDownSensitivity > 0)
				mouseDownSensitivity = 0;
			
			if (mouseLeftSensitivity > 0)
				mouseLeftSensitivity = 0;
		}

		void ModifyMouseRange ()
		{
			float buttonIncrement = .05f;
			if (Input.GetKey(KeyCode.Q))
				mouseUpSensitivity -= buttonIncrement;

			if (Input.GetKey(KeyCode.W))
				mouseUpSensitivity += buttonIncrement;

			if (Input.GetKey(KeyCode.D))
				mouseRightSensitivity -= buttonIncrement;

			if (Input.GetKey(KeyCode.F))
				mouseRightSensitivity += buttonIncrement;

			if (Input.GetKey(KeyCode.Z))
				mouseDownSensitivity -= buttonIncrement;

			if (Input.GetKey(KeyCode.X))
				mouseDownSensitivity += buttonIncrement;

			if (Input.GetKey(KeyCode.A))
				mouseLeftSensitivity -= buttonIncrement;

			if (Input.GetKey(KeyCode.S))
				mouseLeftSensitivity += buttonIncrement;

			CheckForZero();
		}

		void Update ()
		{
			transform.position += new Vector3 (Input.GetAxis(GetAxis.xMouse) * .4f, Input.GetAxis(GetAxis.yMouse) * .4f);
		}

		void OnGUI ()
		{
//			SetCursorState();
		}
	}
}

//transform.position = new Vector3 (Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
