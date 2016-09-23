using UnityEngine;
using System.Collections;

public class ConsolePrinter : MonoBehaviour {

	public Vector2 location;
	public Vector2 homeLocation;

	// Use this for initialization
	void Start () {
		Vector2 pathToHome = homeLocation - location;
		print("Welcome to Go Home!");
		print("A game were you need to find you way back.");
		print("Path to home: " + pathToHome);
		print("Distance to home: " + pathToHome.magnitude);
		if (location == homeLocation)
		{
			print("I am at home!");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			print("Location: " + location);
			print("Left key pressed.");
		}
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			location = new Vector2(2, 3);
			print("Right key pressed.");
		}
	}
}
