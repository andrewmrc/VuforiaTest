using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scomparsa : MonoBehaviour {

    public GameObject dino;
    bool visible = true;

	void Start ()
    {
		
	}
	
	
	public void Plus ()
    {
        dino.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
	}

    public void Minus()
    {
        dino.transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
    }
}
