using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espresso : BeverageBase {

	public Espresso()
	{
		description = "Espresso";
	}

	public override double GetCost ()
	{
		return 150;
	}


}
