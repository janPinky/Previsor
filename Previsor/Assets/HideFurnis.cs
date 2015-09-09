using UnityEngine;
using System.Collections;

public class HideFurnis : MonoBehaviour {


	public GameObject[] furnis;

	void Start () {
		furnis = GameObject.FindGameObjectsWithTag("furni");
	}
	
	// Update is called once per frame
	public void HideFurniture(){


		for(int i=0; i <this.furnis.Length; i++){
			Debug.Log(this.furnis[i].name);
			this.furnis[i].SetActive(false);
			}
	}
}
