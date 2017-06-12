using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour {

    private Transform target;

	void Start () {

        GameObject cam = GameObject.FindWithTag("MainCamera");
        target = cam.transform;
        
        

    }
	
	// Update is called once per frame
	void Update () {

        this.gameObject.transform.LookAt(target);

    }
}
