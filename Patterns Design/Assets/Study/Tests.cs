using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Tests : MonoBehaviour {
	private float xAngle;
	private float YAngle;
	private float mouseSens = 5;
	private Quaternion originRot;
	public Dictionary<int,string> d = new Dictionary<int, string>();
	public int a,b;
	public List<string> [] f = new List<string>[3] ;
	public List<string> someList = new List<string>();
	public List<string> GAGAstrings;

	// Use this for initialization

	void Start () {

		Met ();

		originRot = transform.rotation;
		a = a ^ b;
		b = a ^ b;
		a = a ^ b;
	}

	void Met(){
		
		GAGAstrings = (from x in someList
			where x == "GAGA" || x =="ff"
			select x).ToList();
		Blah (10,20);
	}
	void Blah(int x,int y)
	{
		Debug.Log (x + y);
	}
	void FixedUpdate(){
		xAngle += Input.GetAxis ("Mouse X") * mouseSens;
		YAngle += Input.GetAxis ("Mouse Y") * mouseSens;

		YAngle = Mathf.Clamp (YAngle,-60, 60);

		Quaternion y = Quaternion.AngleAxis (xAngle, Vector3.up);
		Quaternion x= Quaternion.AngleAxis (-YAngle, Vector3.right);
		transform.rotation = originRot * y * x;
	}
	void Update () {

	}

}
