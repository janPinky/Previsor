using UnityEngine;
using System.Collections;

public class ChangeMaterial : MonoBehaviour {

	public Material raufaser;
	public Material glasfaser;
	public Material vlies;




	private Color32 currentcolor;
	public Material currentmaterial;
	public Texture2D editcursor;


	void Start () {




	}


	public void SetRauf(){

		Cursor.SetCursor(editcursor,Vector2.zero,CursorMode.Auto);
		currentmaterial = raufaser;
	
		}

	public void SetGasf(){
		Cursor.SetCursor(editcursor,Vector2.zero,CursorMode.Auto);
		currentmaterial = glasfaser;
		}

	public void SetVlies(){
		Cursor.SetCursor(editcursor,Vector2.zero,CursorMode.Auto);
		currentmaterial = vlies;
		}


	

}