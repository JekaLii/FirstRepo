using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MyLoadBundles : MonoBehaviour {
	public string bundleName;
	public string sceneName;
	public string manifesName;
	AssetBundleManifest manifest;
	// Use this for initialization
	IEnumerator Start () {

		using(WWW www = new WWW("file://D:/MyGames/NewGame/Project/Patterns Design/Assets/Data/" + manifesName))
		{
			yield return www;
			if (!string.IsNullOrEmpty (www.error)) {
				Debug.Log (www.error);
				yield break;
			}

			manifest = www.assetBundle.LoadAsset ("AssetBundleManifest") as AssetBundleManifest;
			yield return null;
			www.assetBundle.Unload (false);

		}



	
		using (WWW www = WWW.LoadFromCacheOrDownload ("file://D:/MyGames/NewGame/Project/Patterns Design/Assets/Data/"+ bundleName, manifest.GetAssetBundleHash(bundleName))) 
		{
			yield return www;
			if (!string.IsNullOrEmpty (www.error)) {
				Debug.Log (www.error);
				yield break;
			}
			SceneManager.LoadScene (sceneName);
			yield return null;
			www.assetBundle.Unload (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
