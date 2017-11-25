using System;
using System.Linq;
using UnityEditor;
using UnityEditor.ProjectWindowCallback;
using UnityEngine;
using System.Reflection;

internal class EndNameEdit : EndNameEditAction
{
	#region implemented abstract members of EndNameEditAction
	public override void Action (int instanceId, string pathName, string resourceFile)
	{
		AssetDatabase.CreateAsset(EditorUtility.InstanceIDToObject(instanceId), AssetDatabase.GenerateUniqueAssetPath(pathName));
	}

	#endregion
}

/// <summary>
/// Scriptable object window.
/// </summary>
public class ScriptableObjectWindow : EditorWindow
{
	private int selectedIndex;
	private string[] names;
	
	private Type[] types;
	
	public Type[] Types
	{ 
		get { return types; }
		set
		{
			types = value;
			names = types.Select(t => t.FullName ).ToArray();
		}
	}
	
	public void OnGUI()
	{
		GUILayout.Label("ScriptableObject Class/GG");
		selectedIndex = EditorGUILayout.Popup(selectedIndex, names);

		if (GUILayout.Button ("Some Button")) 
		{
			
		}
		if (GUILayout.Button("Create"))
		{
			if (types [selectedIndex].ToString () == "Second") {
				UnityEngine.Object[] objects = Resources.LoadAll ("");
				TextAsset[] texts = new TextAsset[objects.Length];
				Debug.Log (objects.Length);
				for (int i = 0; i < objects.Length; i++) {
					texts [i] = (TextAsset)objects [i];
					Debug.Log (texts [i]);

					var asset = ScriptableObject.CreateInstance (types [selectedIndex]);
					ProjectWindowUtil.StartNameEditingIfProjectWindowExists (
						asset.GetInstanceID (),
						ScriptableObject.CreateInstance<EndNameEdit> (), string.Format ("{0}.asset", texts [i].name), AssetPreview.GetMiniThumbnail (asset), null);

					if (asset is Second) {
						Second sec = (Second)asset;

						sec.someText = texts [i].text;

					}
				}

				Close ();
			}
		}
	}
}