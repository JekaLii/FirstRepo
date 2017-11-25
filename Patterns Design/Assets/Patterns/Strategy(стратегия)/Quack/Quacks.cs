using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Strategy
{

	public class SimpleQuack:IQuackable
	{
		public void Quack ()
		{
			Debug.Log ("Quack!");
		}
	}

	public class NoQuack:IQuackable
	{
		public void Quack ()
		{
			
		}
	}

	public class ExoticQuack:IQuackable
	{
		public void Quack ()
		{
			Debug.Log ("ExoticQuack");
		}
	}
}