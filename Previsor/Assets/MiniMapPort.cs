using UnityEngine;
using System.Collections;

public class MiniMapPort : MonoBehaviour {

	public Camera MiniMapCam;
	private Vector3 PlayerPos;
	private int Layers;
	private LayerMask myLayerMask;
	private float yPos;

	void Start () {
		Layers = 0;
		myLayerMask =~(1<<10);
		yPos = 10.14f;
	
	}
	
	// Update is called once per frame
	void Update () {
	

		if(Input.GetMouseButtonDown(0)){
			
			Ray raycast = MiniMapCam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			
			if(Physics.Raycast(raycast, out hit,100,myLayerMask)){
				Debug.Log(hit.transform.gameObject.name);
				PlayerPos = new Vector3(Input.mousePosition.x,yPos,Input.mousePosition.z);
				transform.position = PlayerPos;
			}
	}
}
}