using UnityEngine;
using System.Collections;

public class Component : MonoBehaviour {
	private float itemScale = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// us 0.5f to slow down translate
		transform.Translate(Input.GetAxis("Horizontal") * .5f, 0f, Input.GetAxis ("Vertical") * .5f);
		// look up and down: Mouse Y
		// look left and right: Mouse X
		// triple value with 3f as movements are small
		// make negative to invert left/right
		transform.Rotate(Input.GetAxis("Mouse Y") * 3f, -Input.GetAxis("Mouse X") * 3f, 0);
		if (Input.GetKey (KeyCode.N))
			itemScale -= .1f;
		
		if (Input.GetKey (KeyCode.M))
			itemScale += .1f;
		
		// scale along all axes
		transform.localScale = new Vector3(itemScale, itemScale, itemScale);
	}
}
