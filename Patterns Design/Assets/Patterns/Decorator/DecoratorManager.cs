using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoratorManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		List<BeverageBase> beverages = new List<BeverageBase>
		{
			new Espresso (),
			new BlackTea (),
			new GreenTea (),
			new SugarCondiment(new MilkCondiment(new Espresso()))
		};
//		BeverageBase capuccino = new Capuccino ();
//		BeverageBase hotChocolate = new HotChocolate ();

		foreach (var item in beverages)
		{
//			Debug.Log (string.Format("Beverage: {0}; Price: {1}",item.GetDescription(),item.GetCost().ToString()));
		}
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
