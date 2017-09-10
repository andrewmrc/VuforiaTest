using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {

    public Transform cameraAR;
	
	
	void Update () {

        this.transform.LookAt(cameraAR);
		
	}
}
