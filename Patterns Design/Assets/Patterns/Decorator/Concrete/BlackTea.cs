using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackTea : BeverageBase {

	public BlackTea()
	{
		description = "BlackTea";
	}

	public override double GetCost ()
	{
		return 25;
	}
}
