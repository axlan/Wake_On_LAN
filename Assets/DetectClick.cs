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

		gamestate.Instance.selected = transform.gameObject;

	}

	void OnMouseUp() {

		gamestate.Instance.selected = null;
		
	}

	void OnMouseEnter() {	
		if (gamestate.Instance.selected != null) {
			LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
			lineRenderer.material = new Material(Shader.Find("Particles/Additive"));
			lineRenderer.SetColors(Color.green,Color.red);
			lineRenderer.SetWidth(0.2F, 0.2F);
			lineRenderer.SetVertexCount(2);
		
			lineRenderer.SetPosition(0, selection.transform.position);


			lineRenderer.SetPosition(1, transform.position);

			//Debug.DrawLine (this.transform.position, selection.transform.position,Color.white);
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
