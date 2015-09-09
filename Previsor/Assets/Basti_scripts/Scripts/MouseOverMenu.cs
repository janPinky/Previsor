using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class MouseOverMenu : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	public bool editable;


	void Start () {
	
	}

	public void OnPointerEnter (PointerEventData eventData) 
	{	
		editable = false;
	}


	public void OnPointerExit (PointerEventData eventData) 
	{
		editable = true;
	}
}
