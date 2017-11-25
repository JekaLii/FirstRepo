using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTea : BeverageBase {

	public GreenTea()
	{
		description = "GreenTea";
	}

	public override double GetCost ()
	{
		return 50;
	}
}
