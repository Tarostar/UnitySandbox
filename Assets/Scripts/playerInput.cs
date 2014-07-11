using UnityEngine;
using System.Collections;

public class playerInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("player input");
	}
	
	// Update is called once per frame
	void Update () {
		float hVal = Input.GetAxis ("Horizontal");
		float vVal = Input.GetAxis ("Vertical");
		
		if (hVal !=  0)
			print ("Horizontal movement selected: " + hVal);
		
		if (vVal != 0)
			print ("Horizontal movement selected: " + vVal);
		
		if (Input.GetKey (KeyCode.M))
			print("M pressed");
		
		float mxVal = Input.GetAxis("Mouse X");
		float myVal = Input.GetAxis("Mouse Y");
		
		if (mxVal != 0 || myVal != 0)
			print ("mouse moving");
	}
}
