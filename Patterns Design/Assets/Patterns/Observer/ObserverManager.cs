using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverManager : MonoBehaviour {

	void Start()
	{
		NewsAggregator newsAggregator = new NewsAggregator ();

		var twitterWidget = new TwitterWidget (newsAggregator);
		var lentaWidget = new LentaWidget (newsAggregator);
		var tvWidget = new TvWidget (newsAggregator);

		newsAggregator.NewNewsAvalible ();
		Debug.Log ("------------------------------------------------------------------------------");
		twitterWidget.RemoveFromSubject ();
		newsAggregator.NewNewsAvalible ();
	}

}
