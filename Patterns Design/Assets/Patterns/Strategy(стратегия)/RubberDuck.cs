using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Strategy
{

	public class RubberDuck : DuckBase
	{

		public RubberDuck ()
		{
			flyBehaviour = new NoFly ();
			eatBehaviour = new NoEat ();
		}
		#region implemented abstract members of DuckBase

		public override void Display ()
		{
			Debug.Log ("I am RubberDuck");
		}

		#endregion
	}
}