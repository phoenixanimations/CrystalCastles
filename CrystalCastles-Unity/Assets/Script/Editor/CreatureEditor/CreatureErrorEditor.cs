using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace CrystalCastles.UnityEditor
{
	[CustomEditor (typeof(Creature))]
	public class CreatureErrorEditor : Editor
	{
		protected Creature creature;

		/// <summary>
		/// Makes it so you can use the creature variable.
		/// </summary>
		protected void Initialize ()
		{
			creature = (Creature)target;
		}

		/// <summary>
		/// Displays an error if Height = 0.
		/// </summary>
		protected void DisplayErrorHeight ()
		{
			if (creature.height <= .03f) 
			{
				EditorGUILayout.HelpBox ("Height less than .03, this will cause glitches with the tile system. Make it higher than .03 to avoid glitches.", MessageType.Error);
			}
		}

		/// <summary>
		/// This function has a lot of "unnecessary checks" just in case. The button also uses getcomponent.
		/// Since you're only suppose to click the button once I decided to put in the object. 
		/// </summary>
		/// Possibly clean up this function.
		protected void DisplayErrorSpriteRenderer ()
		{
			if (creature.spriteRenderer == null) 
			{
				EditorGUILayout.HelpBox ("SpriteRenderer is null, this will cause errors with GameManager and any sort of tile sorting. " +
					"Click the button to avoid errors.", MessageType.Error);

				if (GUILayout.Button("Attach SpriteRenderer", GUILayout.Height(14f), GUILayout.Width(132f))) 
				{
					var spriteRenderer = creature.GetComponent<SpriteRenderer> ();
					if (spriteRenderer != null)
					{
						creature.spriteRenderer = spriteRenderer;
					}
					else
					{
						Debug.LogError("SpriteRenderer doesn't exist, why?");
					}
				}
			}
		}

		/// <summary>
		/// This is coded in a very similar way to DisplayErrorSpriteRenderer.
		/// </summary>
		/// Both these methods seem like they could be cleaned up in some way.
		protected void DisplayErrorCircleCollider2D ()
		{
			CircleCollider2D circleCollider2D = creature.GetComponent<CircleCollider2D>();
			if (circleCollider2D != null)
			{
				if (circleCollider2D.offset.x != 4.135f || circleCollider2D.offset.y != 1.175f || circleCollider2D.radius != .03f)
				{
					EditorGUILayout.HelpBox ("CircleCollider2D is not exactly:\nx = 4.135\ny = 1.175\nradius = .03f.\n" +
						"Please click the button to correct this.", MessageType.Error);
					
					if (GUILayout.Button("Set CircleCollder2D", GUILayout.Height(14f), GUILayout.Width(132f)))
					{
						circleCollider2D.offset = new Vector2 (4.135f, 1.175f);
						circleCollider2D.radius = .03f;
					}
				}
			}
			else
			{
				Debug.LogError("Circle Collider 2D doesn't exist, why?");
			}
		}
	}
}