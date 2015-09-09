using UnityEngine;
using System.Collections;

public class SetColor : MonoBehaviour {



	private Color32 cream;
	private Color32 mango;
	private Color32 fresh;
	private Color32 manhatten;
	private Color32 orchidee;
	private Color32 lagune;
	public Color32 wallcolor;
	public Texture2D editcursor;


	void Start () {

		cream = new Color32(255,242,208,255);
		mango = new Color32(241,136,11,255);
		fresh = new Color32(197,216,100,255);
		manhatten = new Color32(145,136,129,255);
		orchidee = new Color32(168,35,98,255);
		lagune = new Color32(0,121,132,255);

	}



	public void ColorCream(){

		Cursor.SetCursor(editcursor,Vector2.zero,CursorMode.Auto);
		wallcolor = cream;
	}

	public void ColorMango(){

		Cursor.SetCursor(editcursor,Vector2.zero,CursorMode.Auto);
		wallcolor = mango;	
	}

	public void ColorFresh(){

		Cursor.SetCursor(editcursor,Vector2.zero,CursorMode.Auto);
		wallcolor = fresh;
	}

	public void ColorManhatten(){

		Cursor.SetCursor(editcursor,Vector2.zero,CursorMode.Auto);
		wallcolor = manhatten;
	}


	public void ColorOrchidee(){

		Cursor.SetCursor(editcursor,Vector2.zero,CursorMode.Auto);
		wallcolor = orchidee;
	}

	public void ColorLagune(){

		Cursor.SetCursor(editcursor,Vector2.zero,CursorMode.Auto);
		wallcolor = lagune;
	}






}
