using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class MouseEvents : MonoBehaviour {

	public IObservable<long> curThread;
	public string whatToDebug;

	// Use this for initialization
	void Start () {


//		AchiveDoubleTapWay1 ();
		AchiveDoubleTapWay2 ();


	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.S))
			SomeTextToDebugLog ();
		
	}

	void DebugLogSomething()
	{
		Debug.Log (whatToDebug);
	}

	void SomeTextToDebugLog()
	{
		if (string.IsNullOrEmpty (whatToDebug))
			HardCalculate ();
		DebugLogSomething ();
	}

	void HardCalculate()
	{
		long[,] gg = new long[10000,10000];
		for (int i = 0; i < gg.Length; ++i)
		{
			for (int j = 0; j < gg.Length; ++j) 
			{
				var rnd = Random.Range (0,500000);
				string str = rnd.ToString ();
				var rnd2 = long.Parse (str);
				gg [i, j] = rnd2;
			}
		}
		whatToDebug = gg [gg.Length / 2, gg.Length / 2].ToString();
	}

	void AchiveDoubleTapWay1()
	{
		var mouseEvent = Observable.EveryUpdate ().Where (_ => Input.GetMouseButtonDown (0));
		curThread = mouseEvent;
		mouseEvent.Buffer (System.TimeSpan.FromMilliseconds (500)).Where (x => x.Count >= 2).Subscribe (_ => Debug.Log ("Milliseconds"));
	}
	void AchiveDoubleTapWay2()
	{
		var mouseEvent = Observable.EveryUpdate ().Where (_ => Input.GetMouseButtonDown (0));
		curThread = mouseEvent;
		mouseEvent.Buffer (mouseEvent.SampleFrame(30)).Where (x => x.Count >= 2).Subscribe (_ => Debug.Log ("SampleFrame"));
	}

	void StopThread()
	{
		
	}

}
