using UnityEngine;
using System.Collections;


public class Scenechange : MonoBehaviour
{




    void Update()
    {
        
        for (int i = 0; i < Input.touchCount; i++) {
            Touch touching = Input.GetTouch(i);


        if (touching.phase == TouchPhase.Began)
        {


            Application.LoadLevel("Gamefield");
        }
    }
}
}