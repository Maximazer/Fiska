using UnityEngine;
using System.Collections;

public class playerdestroy : MonoBehaviour {

	void Start () {
	


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")

			Application.LoadLevel("MainMenu");


	}
}