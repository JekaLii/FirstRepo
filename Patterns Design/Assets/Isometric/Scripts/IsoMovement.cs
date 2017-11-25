using UnityEngine;
using System.Collections;

public class IsoMovement : MonoBehaviour {
	public float stopFactor;
	public Transform charackter;
	public Transform myCamera;
	public float cameraDist;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKey (KeyCode.D))
			Move (Vector3.right);
		if (Input.GetKey (KeyCode.A))
			Move (-Vector3.right);
		if (Input.GetKey (KeyCode.W))
			Move (Vector3.up);
		if (Input.GetKey (KeyCode.S))
			Move (-Vector3.up);
	
	}

	void LateUpdate(){

		myCamera.transform.position = new Vector3 (charackter.transform.position.x,charackter.transform.position.y,cameraDist);

	}

	void Move(Vector3 dir){

		transform.Translate (dir * stopFactor);
	}
}
