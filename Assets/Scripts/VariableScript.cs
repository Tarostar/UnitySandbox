using UnityEngine;
using System.Collections;

public class VariableScript : MonoBehaviour {
	public int number;

	// Use this for initialization
	void Start () {
		int n = 5;
		float y = 3.4f; // default numerical type
		double z = 8.8; // doubles greater accuracy for small numbers
		
		char myChar = 'C';
		string s = "test";
		bool isDone = false;
		
		number = 70;
	}
	
	// Update is called once per frame
	void Update () {
		// print (number);
	}
}
