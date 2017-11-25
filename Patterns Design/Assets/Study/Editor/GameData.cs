using System;
using UnityEditor;
using UnityEngine;

public  class GameData :EditorWindow {

	public static Action someAction;

	[MenuItem("GameData/ScriptableObject")]
	public static void Create(){
		if (someAction != null) {
			Debug.Log ("Is Full");
			someAction ();
		}
		else
			Debug.Log ("Is Empty");


	}
}
