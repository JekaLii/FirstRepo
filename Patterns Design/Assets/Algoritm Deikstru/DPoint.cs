using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class DPoint : MonoBehaviour {

	public List<DPointWeight> closesPoints = new List<DPointWeight> ();
	public int pointNumber;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
[System.Serializable]
public struct DPointWeight{
	public DPoint point;
	public int weight;
	public  DPointWeight(DPoint Point,int Weight)
	{
		point = Point;
		weight = Weight;
	}
}
