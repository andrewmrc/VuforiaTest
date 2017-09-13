using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchElements : MonoBehaviour {

    public GameObject moto;
    public GameObject video;
    public GameObject buttonMoto;
    public GameObject buttonGioco;
    public GameObject buttonReturn;
    public GameObject IcardiImage;

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
        buttonGioco.SetActive(true);
        buttonMoto.SetActive(true);
        IcardiImage.SetActive(true);
    }

    public void returnElements()
    {
        StopAllCoroutines();
        video.layer = 1;
        moto.SetActive(false);
        video.SetActive(true);
        buttonGioco.SetActive(false);
        buttonMoto.SetActive(false);
        IcardiImage.SetActive(false);
        buttonReturn.SetActive(false);

    }

    public void ButtonMoto()
    {
        moto.SetActive(true);

        buttonReturn.SetActive(true);

        buttonGioco.SetActive(false);
        buttonMoto.SetActive(false);
        IcardiImage.SetActive(false);
    }

    public void ButtonReturn()
    {
        buttonReturn.SetActive(false);
        moto.SetActive(false);

        buttonGioco.SetActive(true);
        buttonMoto.SetActive(true);
        IcardiImage.SetActive(true);



    }


    public void OpenWebSite()
    {
        Application.OpenURL("http://www.itsreal.eu/");
    }
    
}
