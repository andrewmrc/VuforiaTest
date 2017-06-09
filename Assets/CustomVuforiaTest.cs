using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vuforia
{

    public class CustomVuforiaTest : MonoBehaviour
    {
        public GameObject targetGO;


        private void Update()
        {

            //targetGO.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, Camera.main.nearClipPlane));

            /*
            if (!targetGO.GetComponentInChildren<Renderer>().isVisible)
            {
                Debug.Log("Oggetto invisibile");
            }
            else
            {
                Debug.Log("Oggetto visibile");
                targetGO.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, Camera.main.nearClipPlane));
            }*/
        }
    }
}