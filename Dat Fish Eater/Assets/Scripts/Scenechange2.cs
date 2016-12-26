using UnityEngine;
using System.Collections;


public class Scenechange2 : MonoBehaviour
{




    void Update()
    {

        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touching = Input.GetTouch(i);


            if (touching.phase == TouchPhase.Began)
            {


                Application.LoadLevel("WinScene");
            }
        }
    }
}