using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VButton : MonoBehaviour, IVirtualButtonEventHandler
{

    private GameObject vbButton;
    public Renderer sphere;

    private void Start()
    {
        vbButton = GameObject.Find("actionButton");
        vbButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        sphere.material.color = Color.red;
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        sphere.material.color = Color.black;
    }

}