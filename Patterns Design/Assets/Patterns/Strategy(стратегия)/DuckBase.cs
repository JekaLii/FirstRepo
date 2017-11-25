using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Strategy
{
	
	public abstract class DuckBase
	{

		protected IFlyable flyBehaviour;
		protected IQuackable quackBehaviour;
		protected IEatable eatBehaviour;

		public DuckBase()
		{
			flyBehaviour = new FlyWithWings ();
			quackBehaviour = new SimpleQuack ();
			eatBehaviour = new FishEat ();
		}

		public void Quack ()
		{
			quackBehaviour.Quack ();
		}

		public void Swim ()
		{
			Debug.Log ("Swim");
		}

		public void Fly()
		{
			flyBehaviour.Fly ();
		}

		public void Eat()
		{
			eatBehaviour.Eat ();
		}

		public abstract void Display ();
	}

}