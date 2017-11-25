using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LitJson;
using System.IO;

public class FirstJsonData : ScriptableObject,IUpdatableScriptableObjects {
	public int[] _array;
	public bool _boolean;
	public int number;
	public List<string> _object;
	public string _string;

	#region IUpdatableScriptableObjects implementation

	public void UpdateData ()
	{
		string jsonString = File.ReadAllText ("Assets/Resources/MyJson.json");
		JsonData jsonFile = JsonMapper.ToObject (jsonString);
		jsonFile = jsonFile [name];
		foreach (string key in jsonFile.Keys) {
			switch (key) {
			case"array":
				_array = new int[jsonFile [key].Count];
				for (int i = 0; i < _array.Length; i++) {
					_array [i] = (int) jsonFile [key] [i];
				}
				break;
			case"object":
				_object = new List<string> ();
				foreach (string key2 in jsonFile["object"].Keys)
					_object.Add ((string)jsonFile["object"][key2]);
				break;
			default:
				break;
			}
		}
	}

	#endregion
}
public interface IUpdatableScriptableObjects{
	 void UpdateData();
}