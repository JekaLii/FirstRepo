using UnityEngine;
using System.Collections;
using System.Linq;
using UnityEditor;
using System.IO;
using LitJson;

public class MyCreatorWindow : EditorWindow  {
	[MenuItem("Assets/Create/MyCreator")]
	public static void Creator(){
		Debug.Log ("Creator");
		var window = EditorWindow.GetWindow<MyCreatorWindow>();
	}
	void OnGUI()
	{
		GUILayout.Label ("MyCreatorBlahblah");
		if (GUILayout.Button ("Create")) {
			Debug.Log ("MyCreate");
			CreateScriptableObjects ();
		}
	}
	void CreateScriptableObjects(){
		string jsonString = File.ReadAllText ("Assets/Resources/MyJson.json");

//		TextReader jsonString = (TextReader)Resources.Load("MyJson.json",typeof(TextReader));
		JsonData jsonFile = JsonMapper.ToObject (jsonString);
		int index = 0;
		foreach (string key in jsonFile.Keys) {
			foreach (string sid in jsonFile[key].Keys)
				if (sid == "string") {
					CreateObject (key);
					index++;
				}
		}
		Debug.Log (index);


//		Debug.Log (allFiles.Length);
//		Debug.Log(jsonFile[1]["string"]);
	}
	void CreateObject(string _name){
		
//		FirstJsonData data = new FirstJsonData ();
		var asset = ScriptableObject.CreateInstance<FirstJsonData> ();
		AssetDatabase.CreateAsset (asset,"Assets/Study/" + _name +".asset");
		AssetDatabase.SaveAssets ();
		AssetDatabase.Refresh ();
	}
	}
