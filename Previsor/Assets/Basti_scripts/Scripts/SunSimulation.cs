using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SunSimulation : MonoBehaviour {

	private float RotationY;
	public Slider slider;

	public void RotateY()
	{
		RotationY = slider.value;
		Debug.Log(slider.value.ToString ());
		transform.localEulerAngles = new Vector3 (RotationY, 0, 0);
	}
}