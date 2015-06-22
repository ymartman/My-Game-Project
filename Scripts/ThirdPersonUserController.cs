using UnityEngine;
using System.Collections;

public class ThirdPersonUserController : MonoBehaviour {

	private Transform m_Cam;

	// Use this for initialization
	void Start () {
		// get the transform of the main camera
		if (Camera.main != null)
		{
			m_Cam = Camera.main.transform;
		}
		else
		{
			Debug.LogWarning(
				"Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
