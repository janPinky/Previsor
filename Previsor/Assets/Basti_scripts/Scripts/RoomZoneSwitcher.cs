using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RoomZoneSwitcher : MonoBehaviour {

	public Text zoneSwitchText;
	public string zone;


	void OnTriggerEnter(Collider player){

		zone = gameObject.name;
		zoneSwitchText.text=zone;
	}
}
