using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CrystalCastles
{
	public static class Sort
	{
		/// <summary>
		/// Sorts a list of creatures to overlap in the correct way. Modifies creature.spriteRenderer.sortingOrder variable.
		/// </summary>
		/// I don't know if the parameter variable is pointing at the same
		/// location as the original variable.
		/// The question is does extensions naturally avoid this problem? Something to look into one day.
		/// A GLITCH this should not preserve the Layer reorder. Make it save it as
		/// another list and then continue. The funny thing is I don't think it does preserve the Layer reorder. 
		/// This method is misleading as it does more than just sort.
		public static List <Creature> Layer (this List <Creature> creatureList)
		{
			if (creatureList.Count > 0)
			{
				int layer = 0;
				creatureList.OrderBy(s => s.worldHeight)
						    .ThenByDescending(p => Mathf.Floor(p.transform.position.y * 100f))
						    .ThenBy(p => Mathf.Floor(p.transform.position.x * 100f))
						    .ToList()
						    .ForEach(l => l.spriteRenderer.sortingOrder = layer++);
			}
			return creatureList;
		}
	}
}