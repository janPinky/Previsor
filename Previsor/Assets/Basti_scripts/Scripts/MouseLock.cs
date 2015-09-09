using UnityEngine;
using System.Collections;
using UnityStandardAssets;
using UnityStandardAssets.Characters.FirstPerson;


public class MouseLock : MonoBehaviour {

	void Start(){
		GetComponent<FirstPersonController>().mouseLocker = false;
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		}

	public void MouseLocked(){

		GetComponent<FirstPersonController>().mouseLocker = false;
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}


	public void MouseUnlocked(){

		GetComponent<FirstPersonController>().mouseLocker = true;
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}
}
