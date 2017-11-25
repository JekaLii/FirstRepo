using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Strategy
{

	public class FishEat : IEatable
	{
		public void Eat ()
		{
			Debug.Log ("I am eat fish");
		}
	}

	public class NoEat : IEatable
	{
		public void Eat ()
		{
		}
	}
}