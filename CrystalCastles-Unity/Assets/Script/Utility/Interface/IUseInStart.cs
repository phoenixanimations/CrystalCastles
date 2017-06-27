using System.Collections;

namespace CrystalCastles
{
	interface IUseInStart
	{
		/// <summary>
		/// This function should be used in the GameManager's start function.
		/// This function is only meant to run once. Much like a regular class constructor.
		/// </summary>
		void UseInStart ();
	}
}
