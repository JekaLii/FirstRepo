using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Strategy
{

	public class WoodenDuck : DuckBase
	{

		public WoodenDuck()
		{
			flyBehaviour = new NoFly ();
			quackBehaviour = new NoQuack ();
			eatBehaviour = new NoEat ();
		}

		#region implemented abstract members of DuckBase

		public override void Display ()
		{
			Debug.Log ("I am WoodenDuck");
		}

		#endregion
	}
}