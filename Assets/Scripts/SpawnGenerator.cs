using UnityEngine;
using System.Collections;

public class SpawnGenerator : MonoBehaviour {
	public GameObject prefab;
	// GUIScript is name of the GUI menu script!
	public GUIScript gui;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.B))
		{
			Instantiate (prefab);
			gui.AddBall();
		}
		
		if (Input.GetKeyDown (KeyCode.Space))
			Instantiate (prefab, transform.position, transform.rotation);
	}
}
