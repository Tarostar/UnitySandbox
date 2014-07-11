using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {
	private int ballcount = 0;
		
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
	
	void OnGUI()
	{	
		GUI.Box (new Rect(Screen.width / 2 - 50,0,100,50), "Balls");
		GUI.Label (new Rect(Screen.width / 2, 20, 90, 20), ballcount.ToString ());
		
		if (GUI.Button (new Rect((Screen.width / 2) - 50, Screen.height - 30, 100, 20), "Reset"))
		{
			ballcount = 0;
			print ("Reset");
		}
	}
	
	public void AddBall()
	{
		ballcount++;
	}
	
}
