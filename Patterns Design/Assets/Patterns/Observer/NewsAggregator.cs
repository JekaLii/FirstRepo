using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewsAggregator : MonoBehaviour,ISubject {
	
	private static System.Random _random;

	private List<IObserver> observers;


	public NewsAggregator()
	{
		_random = new System.Random ();

		observers = new List<IObserver> ();
	}

	public string GetTwitterNews()
	{
		var news = new List<string> {
			"Новость из Twitter номер 1",
			"Новость из Twitter номер 2",
			"Новость из Twitter номер 3"
		};

		return news[_random.Next(3)];
	}

	public string GetLentaNews()
	{
		var news = new List<string> {
			"Новость из Lenta номер 1",
			"Новость из Lenta номер 2",
			"Новость из Lenta номер 3"
		};

		return news[_random.Next(3)];
	}

	public string GetTvNews()
	{
		var news = new List<string> {
			"Новость из TV номер 1",
			"Новость из TV номер 2",
			"Новость из TV номер 3"
		};

		return news[_random.Next(3)];
	}

	public void NewNewsAvalible()
	{
		NotifyObservers ();
	}

	#region ISubject implementation

	public void RegisterObserver (IObserver observer)
	{
		observers.Add (observer);
	}

	public void RemoveObserver (IObserver observer)
	{
		observers.Remove (observer);
	}

	public void NotifyObservers ()
	{

		string twitter = GetTwitterNews ();
		string lenta = GetLentaNews();
		string tv = GetTvNews();

		foreach (var observer in observers) 
		{
			observer.Update (twitter,lenta,tv);
		}
	}

	#endregion
}
