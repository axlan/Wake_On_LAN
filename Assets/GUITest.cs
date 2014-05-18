// C#
using UnityEngine;
using System.Collections;

public class GUITest : MonoBehaviour {
	
	void OnGUI () {
		if (Time.time % 2 < 1) {
			if (GUI.Button (new Rect (10,10,200,20), "Meet the flashing button")) {
				print ("You clicked me!");
			}
		}
	}
}