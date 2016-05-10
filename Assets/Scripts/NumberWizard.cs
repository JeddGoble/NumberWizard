using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max = 1000;
	int min = 1;
	int guess;

	// Use this for initialization
	void Start () {
		guess = max / 2; // Set first guess to half the max

		print ("Welcome to Number Wizard!");
		print ("Think of a number between " + min + " and " + max + ", but don't tell me.");
		print ("Press up for higher, down for lower, and enter for a correct guess.");
		print ("Now, is your number higher or lower than " + guess + "?");

		max += 1; // Must increase max guess by 1 in order to avoid edge case of int rounding down for max value
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {

				min = guess;
				guess = (max + min) / 2;
				print ("Is you number higher or lower than " + guess + "?");

		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
				 
				max = guess;
				guess = (max + min) / 2;
				print ("Is your number higher or lower than " + guess + "?");

		} else if (Input.GetKeyDown (KeyCode.Return)) {

			print ("I won!");

		}
	}
}
