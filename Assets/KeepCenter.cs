using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepCenter : MonoBehaviour
{
    Vector3 centerCamera = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, Camera.main.nearClipPlane));

    void Start ()
    {
        this.transform.position = centerCamera;
    }
	
	
	void Update ()
    {
        this.transform.position = centerCamera;
    }
}
