using UnityEngine;
using System.Collections;

public class ConsolePrinter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float location = 2.1f; // Distance in meters
		float homeLocation = 2.1f;
		float distance = homeLocation - location;
		print("Welcome to Go Home!");
		print("A game were you need to find you way back.");
		print("Distance: " + distance);
		if (location > homeLocation)
		{
			print("Go back to get home!");
		}
		if (location < homeLocation)
		{
			print("Go forward to get home!");
		}
		if (location == homeLocation)
		{
			print("I am at home!");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
