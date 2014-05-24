
// C#
using UnityEngine;
using System.Collections;

public class FileMenuGUI : MonoBehaviour {
	
	public Texture2D icon;
	
	void OnGUI () {
		if(GUI.Button (new Rect (10,10,100,20), new GUIContent ("Menu", icon)))
		{
			print("Clicked Menu");
		}
	}
	
}