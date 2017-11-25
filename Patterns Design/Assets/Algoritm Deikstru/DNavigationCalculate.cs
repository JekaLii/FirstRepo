using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DNavigationCalculate : MonoBehaviour {

	public List<DPoint> allPoints = new List<DPoint>();
	public  List<DIteration> iterations = new List<DIteration>();
	public List<DPoint> trueway = new List<DPoint> ();

	// Use this for initialization
	void Start () {
		GetAllPoints ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GetAllPoints(){
		for (int i = 0; i < transform.childCount; i++) {
			allPoints.Add (transform.GetChild(i).GetComponent<DPoint>());
			allPoints [i].pointNumber = i;
		}
		trueway = GetPath (allPoints[0],allPoints[12]);
	}
	public List<DPoint> GetPath(DPoint startPoint,DPoint finishPoint){
		List<DPoint> way = new List<DPoint> ();
		List<DCheckPoint> bestCheckPoints = new List<DCheckPoint> ();
//		List<DIteration> iterations = new List<DIteration>();
		DIteration iteration = new DIteration ();
		iteration.AddPoint (startPoint,startPoint,0);
		iterations.Add (iteration);
		DPoint currPoint = startPoint;

		while (true) {
			List<DCheckPoint> CPL = new List<DCheckPoint> ();
			foreach (DIteration IT in iterations) {

				DCheckPoint CP = IT.GetLessWeight ();
				Debug.Log (CP.currPoint.name);
				//CP = (bestCheckPoints.Find (x => x.currPoint == CP.currPoint));

				if (bestCheckPoints.Count == 0) {
					bestCheckPoints.Add (CP);
					Debug.Log (bestCheckPoints.Count + "BEST");
				}
					

				foreach (DCheckPoint y in bestCheckPoints) {
					if (y.currPoint == CP.currPoint) {
							Debug.Log ("SAME");
						break;
					} else {
						Debug.Log (CP.currPoint.name);
						CPL.Add (CP);
					}
				}

			}

			//CPL.Sort((x, y) => x.weight);
			//Debug.Log (CPL[0].weight);
			break;
		}

		return way;
}
}
[System.Serializable]
public struct DCheckPoint{

	public  DPoint currPoint;
	public  DPoint lastPoint;
	public int weight;

	public  DCheckPoint(DPoint CurrPoint,DPoint LastPoint,int Weight){
		
		currPoint = CurrPoint;
		lastPoint = LastPoint;
		weight = Weight;
	}
}
[System.Serializable]
public struct DIteration{

	public	List<DCheckPoint> checkPoints ;
	public void AddPoint(DPoint currPoint,DPoint lastPoint,int weight){
		checkPoints = new List<DCheckPoint> ();
		Debug.Log (currPoint.name +" /" + lastPoint.name +"/"+ weight);
		DCheckPoint CP = new DCheckPoint (currPoint,lastPoint,weight);
		//checkPoints.Add (new DCheckPoint (currPoint,lastPoint,weight));
			checkPoints.Add(CP);
			}
	public DCheckPoint GetLessWeight(){

		DCheckPoint p = new DCheckPoint ();
		p.weight = 999999999;
		foreach (DCheckPoint point in checkPoints) {
			 if (p.weight > point.weight)
				p = point;
		}
		return p;
	}
}
