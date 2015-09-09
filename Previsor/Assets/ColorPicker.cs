using UnityEngine;
using System.Collections;

public class ColorPicker : MonoBehaviour {

	private GameObject[] walls;
	private Color DefaultColor;
	public Color[] ExmplColors;
	private int counter;


	// Use this for initialization
	public void Start () {
		counter = 0;
		ExmplColors = new Color[4];
		ExmplColors[0] = Color.blue;
		ExmplColors[1] = Color.red;
		ExmplColors[2] = Color.green;
		ExmplColors[3] = Color.yellow;
		walls = GameObject.FindGameObjectsWithTag("wall");
		DefaultColor = walls[1].GetComponent<Renderer>().material.color;
	}
	
	// Update is called once per frame
	void Update () {
		var d = Input.GetAxis("Mouse ScrollWheel");

		if(d > 0f){

			if (counter <= ExmplColors.Length-1){
			walls[0].GetComponent<Renderer>().material.color = ExmplColors[counter];
			walls[1].GetComponent<Renderer>().material.color = ExmplColors[counter];
			walls[2].GetComponent<Renderer>().material.color = ExmplColors[counter];
			walls[3].GetComponent<Renderer>().material.color = ExmplColors[counter];
			
			}
			counter+=1;

			if(counter == 5){

				walls[0].GetComponent<Renderer>().material.color = DefaultColor;
				walls[1].GetComponent<Renderer>().material.color = DefaultColor;
				walls[2].GetComponent<Renderer>().material.color = DefaultColor;
				walls[3].GetComponent<Renderer>().material.color = DefaultColor;
				counter=0;
			}
		}

		if(d < 0f){
			
			if (counter <= ExmplColors.Length-1){
				walls[0].GetComponent<Renderer>().material.color = ExmplColors[counter];
				walls[1].GetComponent<Renderer>().material.color = ExmplColors[counter];
				walls[2].GetComponent<Renderer>().material.color = ExmplColors[counter];
				walls[3].GetComponent<Renderer>().material.color = ExmplColors[counter];
				
			}
			counter-=1;
			
			if(counter <= 0){
				
				walls[0].GetComponent<Renderer>().material.color = DefaultColor;
				walls[1].GetComponent<Renderer>().material.color = DefaultColor;
				walls[2].GetComponent<Renderer>().material.color = DefaultColor;
				walls[3].GetComponent<Renderer>().material.color = DefaultColor;
				counter=5;
			}
		}

}
}
