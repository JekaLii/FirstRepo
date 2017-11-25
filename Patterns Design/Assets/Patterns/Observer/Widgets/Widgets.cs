using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LentaWidget:IObserver,IWidget
{
	string message;
	ISubject subject;

	public LentaWidget(ISubject subject)
	{
		this.subject = subject;
		subject.RegisterObserver (this);
	}

	public void Update(string twitter,string lenta,string tv)
	{
		message = lenta;
		Display ();
	}

	public void Display()
	{
		Debug.Log (string.Format("Lenta : {0}",message));
	}

	public void RemoveFromSubject()
	{
		subject.RemoveObserver (this);
	}
}

public class TvWidget:IObserver,IWidget
{

	string message;
	ISubject subject;

	public TvWidget(ISubject subject)
	{
		this.subject = subject;
		subject.RegisterObserver (this);
	}

	public void Update(string twitter,string lenta,string tv)
	{
		message = tv;
		Display ();
	}

	public void Display()
	{
		Debug.Log (string.Format("TV : {0}",message));
	}

	public void RemoveFromSubject()
	{
		subject.RemoveObserver (this);
	}
}

public class TwitterWidget:IObserver,IWidget
{

	string message;
	ISubject subject;

	public TwitterWidget(ISubject subject)
	{
		this.subject = subject;
		subject.RegisterObserver (this);
	}

	public void Update(string twitter,string lenta,string tv)
	{
		message = twitter;
		Display ();
	}

	public void Display()
	{
		Debug.Log (string.Format("Twitter : {0}",message));
	}

	public void RemoveFromSubject()
	{
		subject.RemoveObserver (this);
	}
}
