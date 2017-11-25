using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObserver {

	void Update(string twitter,string lenta,string tv);
	void Display ();
	void RemoveFromSubject();
}
