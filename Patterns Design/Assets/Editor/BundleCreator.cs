using UnityEngine;
using System.Collections;
using UnityEditor;

public class BundleCreator  {

	[MenuItem("BundleCreator/Build")]
	static void MYCreateBundle()
	{
		string path = EditorUtility.SaveFolderPanel ("Save Bundle", "", "");
		if (path.Length != 0) 
		{
			BuildPipeline.BuildAssetBundles (path, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
		}
	}
}
