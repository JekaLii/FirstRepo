using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Strategy
{

	public class SimpleDuck : DuckBase
	{
		#region implemented abstract members of DuckBase

		public override void Display ()
		{
			Debug.Log ("I am SimpleDuck");
		}

		#endregion
	}
}