using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Strategy
{

	public class FlyWithWings:IFlyable
	{
		public void Fly ()
		{
			Debug.Log ("FlyWithWings!");
		}
	}

	public class NoFly:IFlyable
	{
		public void Fly ()
		{
			
		}
	}
}