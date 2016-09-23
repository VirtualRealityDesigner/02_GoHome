using UnityEngine;
using System.Collections;

public class ConsolePrinter : MonoBehaviour {

	public Vector2 location;
	public Vector2 homeLocation;

	// Use this for initialization
	void Start () {
		print("Welcome to Go Home!");
		print("A game were you need to find you way back.");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			location = location + new Vector2(-1, 0);
			Vector2 pathToHome = homeLocation - location;
			print("Distance to home: " + pathToHome.magnitude);
			if (location == homeLocation)
			{
				print("I am at home!");
			}
		}
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			location = location + new Vector2(1, 0);
			Vector2 pathToHome = homeLocation - location;
			print("Distance to home: " + pathToHome.magnitude);
			if (location == homeLocation)
			{
				print("I am at home!");
			}
		}
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			location = location + new Vector2(0, 1);
			Vector2 pathToHome = homeLocation - location;
			print("Distance to home: " + pathToHome.magnitude);
			if (location == homeLocation)
			{
				print("I am at home!");
			}
		}
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			location = location + new Vector2(0, -1);
			Vector2 pathToHome = homeLocation - location;
			print("Distance to home: " + pathToHome.magnitude);
			if (location == homeLocation)
			{
				print("I am at home!");
			}
		}
	}
}
