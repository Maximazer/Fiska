using UnityEngine;
using System.Collections;

public class fooddestroy : MonoBehaviour
{

    int Score = 0;
    public GameObject Player;
    public GameObject Hungersc;


    // Use this for initialization
    void Start()
    {
        Player = GameObject.Find("Player");


    }

    void OnGUI() { GUI.Label(new Rect(100, 10, 100, 100), "Score: " + Score); }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("OnTriggerEnter() was called");
        if (other.gameObject.name == "food")
        {
            Debug.Log("Other object is a coin");
            Score += 5;
            Hungersc.transform.position = new Vector3(0, Hungersc.transform.position.y, Hungersc.transform.position.z);
            Hungersc.transform.localScale = new Vector3(1, 1, 1);
            Debug.Log("Score is now " + Score);
            Destroy(other.gameObject);
            if (Score == 40)

                Application.LoadLevel("WinScene");

        }


    }
}

