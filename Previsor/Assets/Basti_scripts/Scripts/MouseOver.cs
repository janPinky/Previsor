using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MouseOver : MonoBehaviour {


	public GameObject wall;
	private Canvas canvas;

	void Start(){

		canvas = GameObject.Find("Menu").GetComponentInChildren<Canvas>();
		//Debug.Log (wall.GetComponent<Renderer>().materials[0].ToString());
	}


	void Update () {
	
		//Debug.Log(canvas.name.ToString());
		if(Input.GetMouseButtonDown(0)){

			Ray raycast = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

		if(Physics.Raycast(raycast, out hit)){

				if(hit.transform.gameObject.tag == "wall"){

						if(canvas.GetComponentInChildren<MouseOverMenu>().editable == true){

					hit.transform.gameObject.GetComponent<Renderer>().material = canvas.GetComponent<ChangeMaterial>().currentmaterial;
							hit.transform.gameObject.GetComponent<Renderer>().material.color = canvas.GetComponent<SetColor>().wallcolor;
							Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);

						}
				}
				


		}
		}
	
	
	}
}
