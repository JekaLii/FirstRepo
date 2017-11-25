using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BeverageBase {

	protected string description;

	public string GetDescription()
	{
		return description;
	}

	public abstract double GetCost ();
}
