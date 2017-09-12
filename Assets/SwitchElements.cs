using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchElements : MonoBehaviour {

    public GameObject moto;
    public GameObject video;
    public GameObject button;
    public GameObject buttonReturn;

    public void enabledElements()
    {
        StartCoroutine(switchElements());

    }

    IEnumerator switchElements()
    {
        video.layer = 1;
        yield return new WaitForSeconds(0.6f);
        video.layer = 0;
        yield return new WaitForSeconds(6.5f);
        video.layer = 1;
        video.SetActive(false);
        //attivo il pulsante che serve per attivare la moto
        button.SetActive(true);
        
    }

    public void returnElements()
    {
        StopAllCoroutines();
        video.layer = 1;
        moto.SetActive(false);
        video.SetActive(true);
        button.SetActive(false);
        buttonReturn.SetActive(false);

    }

    public void ButtonMoto()
    {
        moto.SetActive(true);
        button.SetActive(false);
        buttonReturn.SetActive(true);
    }

    public void ButtonReturn()
    {
        buttonReturn.SetActive(false);
        moto.SetActive(false);
        button.SetActive(true);
    }
    
}
