using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchElements : MonoBehaviour {

    public GameObject moto;
    public GameObject video;

    public void enabledElements()
    {
        StartCoroutine(switchElements());

    }

    IEnumerator switchElements()
    {
        video.layer = 1;
        yield return new WaitForSeconds(0.5f);
        video.layer = 0;
        yield return new WaitForSeconds(6.5f);
        video.layer = 1;
        video.SetActive(false);
        moto.SetActive(true);
    }

    public void returnElements()
    {
        video.layer = 1;
        moto.SetActive(false);
        video.SetActive(true);
        
    }

    
}
