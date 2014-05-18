using UnityEngine;
using System.Collections;

public class DetectClick : MonoBehaviour {

	GameObject selection;

	// Use this for initialization
	void Start () {
		selection=GameObject.Find ("Selection");
	}
	void OnMouseDown() {
		selection.transform.position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
