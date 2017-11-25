using UnityEngine;
using UnityEditor;
using System.Collections;
using System.IO;
[InitializeOnLoad]
public static class UpdateScriptableObject  
{
	static	UpdateScriptableObject(){
		GameData.someAction += () => {
			var info = new DirectoryInfo("Assets/Study");
			var fileInfo = info.GetFiles();

			foreach(FileInfo f in fileInfo)
			{
				
//				Debug.Log(f.Name);
//				Object o = f;
				var asset =  (IUpdatableScriptableObjects)AssetDatabase.LoadAssetAtPath("Assets/Study/"+f.Name,typeof(IUpdatableScriptableObjects));
				if(asset is IUpdatableScriptableObjects)
				{
					(asset as IUpdatableScriptableObjects).UpdateData();
				}
			}
		};
	}
}
