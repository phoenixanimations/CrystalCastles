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
		CircleCollider2D circleCollider2D;
		SpriteRenderer spriteRenderer;

		/// <summary>
		/// Makes it so you can use the variables.
		/// </summary>
		protected void Initialize ()
		{
			creature = (Creature)target;
			spriteRenderer = creature.GetComponent<SpriteRenderer> ();
			circleCollider2D = creature.GetComponent<CircleCollider2D>();
		}

		/// <summary>
		/// Displays an error if Height = 0.
		/// </summary>
		protected void DisplayErrorCreatureHeight ()
		{
			if (creature.creatureHeight <= .03f) 
			{
				EditorGUILayout.HelpBox ("Creature Height less than " + circleCollider2D.radius + ", this will cause glitches with the tile system. " +
					"Make it higher than " + circleCollider2D.radius + " to avoid glitches. The size of a human is 4.9f", MessageType.Error);
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

		/// <summary>
		/// Checks to make sure you have CreaturePhysics attached.
		/// </summary>
		protected void DisplayCreaturePhysicsError ()
		{
			if (creature.creaturePhysics == null)
			{
				EditorGUILayout.HelpBox("Creature Physics is null, this will cause errors when trying to move, and most combat moves.", MessageType.Error);
				if (GUILayout.Button("Set Creature Physics", GUILayout.Height(14f), GUILayout.Width(130f)))
				{
					creature.creaturePhysics = creature.GetComponent<CreaturePhysics>();
				}
			}
		}

		/// <summary>
		/// Checks to make sure that creature front isn't {0, 0, 0}.
		/// </summary>
		protected void DisplayFrontError ()
		{
			if (creature.front == Vector2.zero)
			{
				EditorGUILayout.HelpBox("Front = {0, 0}, this will cause glitches. Click the button to avoid glitches", MessageType.Error);
				if (GUILayout.Button("Set Front", GUILayout.Height(14f), GUILayout.Width(70f)))
				{
					creature.front = VectorCreature.Right;
				}
			}
		}
	}
}