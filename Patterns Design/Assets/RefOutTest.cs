using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefOutTest : MonoBehaviour {

	private SomeRefClass someRefClass;
	private string someString;

	// Use this for initialization
	void Start () {

		someRefClass = new SomeRefClass ("Start",1);
		Debug.Log ("Start " +someRefClass.intValue);
		Change (someRefClass);
		Debug.Log ("Start " +someRefClass.intValue);

//		someString = "Start";
//		Change (someString);
//		Debug.Log ("Start " +someString);
	}

	void Change(SomeRefClass _someRefClass)
	{
//		_someRefClass.stringValue = "Method";
		_someRefClass.intValue = 2;
		Debug.Log ("Method " +_someRefClass.intValue);
		_someRefClass = null;
	}

	void Change(string _someString)
	{
		_someString = "Method";
		Debug.Log ("Method " +_someString);
	}
}

public class SomeRefClass
{
	public string stringValue;
	public int intValue;

	public SomeRefClass(string stringValue,int intValue)
	{
		this.stringValue = stringValue;
		this.intValue = intValue;
	}
	public void SetValues(string stringValue,int intValue)
	{
		this.stringValue = stringValue;
		this.intValue = intValue;
	}
}
