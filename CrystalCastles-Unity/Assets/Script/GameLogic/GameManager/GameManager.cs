using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CrystalCastles;

namespace CrystalCastles
{
	/// <summary>
	/// Game Manager is the only class to use the Update function.
	/// Game Manager tries to emulate the coding style of Input -> Logic -> Render.
	/// Sometimes, because of the design of Unity and my code, Logic/Render are blurred.
	/// </summary>
	/// Only the GameManager Prefab should have anything that uses Start, Update, FixedUpdate etc. 
	public class GameManager : MonoBehaviour
	{
		public List<Creature> creatureList = new List<Creature> ();
		
		void Update ()
		{
			creatureList.Layer();
		}
	}
}
