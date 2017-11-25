using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Strategy
{

	public class ExoticDuck : DuckBase
	{

		public ExoticDuck ()
		{
			quackBehaviour = new ExoticQuack ();
		}

		#region implemented abstract members of DuckBase

		public override void Display ()
		{
			Debug.Log ("I am ExotickDuck");
		}

		#endregion
	}
}