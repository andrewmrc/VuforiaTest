using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontOfCamera : MonoBehaviour {

    public Camera arCamera;
	
	void Update () {

        Transform cameraTransform = arCamera.transform;
        Vector3 eulerAngles = arCamera.transform.rotation.eulerAngles;
        eulerAngles = new Vector3(-90, eulerAngles.y, 0);
        transform.rotation = Quaternion.Euler(eulerAngles);

    }
}
