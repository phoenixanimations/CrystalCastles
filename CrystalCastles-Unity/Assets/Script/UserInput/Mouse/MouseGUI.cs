using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrystalCastles
{
	public class MouseGUI : MonoBehaviour
	{
		void Update ()
		{
//			Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));
			transform.position = new Vector3 (Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
		}
	}
}
