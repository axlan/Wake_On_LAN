using UnityEngine;
using System.Collections;

public class DetectClick : MonoBehaviour {

	public GameObject connector;

	GameObject selection;

	// Use this for initialization
	void Start () {
		selection=GameObject.Find ("Selection");
	}
	void OnMouseDown() {
		selection.transform.position = transform.position;

		gamestate.Instance.selected = transform.gameObject;

	}

	void OnMouseUp() {

		gamestate.Instance.selected = null;
		
	}

	void OnMouseEnter() {	
		if (gamestate.Instance.selected != null) {
		
			GameObject instance=(GameObject)Instantiate(connector);



			float xPos=(selection.transform.position.x+transform.position.x)/2;
			float yPos=(selection.transform.position.y+transform.position.y)/2;


			instance.transform.position=new Vector2(xPos,yPos); 

			//Debug.DrawLine (this.transform.position, selection.transform.position,Color.white);
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
