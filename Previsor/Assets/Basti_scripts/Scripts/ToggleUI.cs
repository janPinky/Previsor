using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;
using UnityEngine.UI;

public class ToggleUI : MonoBehaviour {

	private bool canvasOn;
	public Canvas PrevisorUI;

	public GameObject Player;
	private Animator anim;



	public Button exitButton;
	public Sprite overrideSprtBack;
	public Sprite overrideSprtM;
	public Text MenuInfo;
	//public GameObject MenuBorder;
	public GameObject minimapCam;
	int switchTrigger;



	void Start () {

		canvasOn = false;
		anim = PrevisorUI.GetComponent<Animator>();
		switchTrigger = Animator.StringToHash("Switch");

	}
	
	// Update is called once per frame
	void Update () {

		bool menubutton = Input.GetKeyDown(KeyCode.M);
		if(menubutton){




			if(canvasOn==false){

				anim.SetTrigger(switchTrigger);
				Player.GetComponent<MouseLock>().MouseUnlocked();
				//MenuBorder.SetActive(true);
				MenuInfo.enabled=false;
				//minimapCam.SetActive(false);
				canvasOn = true;

			}else{


				Debug.Log("wurde aufgerufen");
				anim.SetTrigger(switchTrigger);
				Player.GetComponent<MouseLock>().MouseLocked();
				//MenuBorder.SetActive(false);
				MenuInfo.enabled=true;
				//minimapCam.SetActive(true);
				canvasOn = false;
		
		}
		
		}
	
		if(anim.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.MenuDropDown")){
			Camera.main.GetComponent<VignetteAndChromaticAberration>().enabled=true;
			exitButton.image.overrideSprite = overrideSprtBack;
		
		}else{

		if(!anim.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.MenuUp")){
			
			Camera.main.GetComponent<VignetteAndChromaticAberration>().enabled=false;
			exitButton.image.overrideSprite = overrideSprtM;

			}
		}
		
	
	}


	public void ResetOnExit(){

		anim.SetTrigger(switchTrigger);
		MenuInfo.enabled=true;
		//minimapCam.SetActive(true);
		//Camera.main.GetComponent<Blur>().enabled=false;
		Player.GetComponent<MouseLock>().MouseLocked();
		//MenuBorder.SetActive(false);
		canvasOn=false;
		
	}
	}

