using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Strategy
{
	
	public class StrategyManager : MonoBehaviour
	{

		// Use this for initialization
		void Start ()
		{

			List<DuckBase> ducks = new List<DuckBase> ();
			ducks.Add (new ExoticDuck());
			ducks.Add (new SimpleDuck());
			ducks.Add (new WoodenDuck());
			ducks.Add (new RubberDuck());
			ExoticDuck gg = new ExoticDuck ();

			foreach (var duck in ducks) {
				duck.Display ();
				duck.Swim ();
				duck.Quack ();
				duck.Fly ();
				duck.Eat ();
				Debug.Log ("-------------------------------------------------");
			}
		
		}
	
		// Update is called once per frame
		void Update ()
		{
		
		}
	}
}