using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
    /// 

    /// 1 - скорость движения
    /// 

    public Vector2 speed = new Vector2(1, 1);

    // 2 - направление движения
    private Vector2 movement;

    void Update()
    {
        // 3 -  извлечь информацию оси
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        if (Input.touchCount > 0)
        {
            inputX = Input.touches[0].deltaPosition.x;
            inputY = Input.touches[0].deltaPosition.y;
        }

        // 4 - движение в каждом направлении
        movement = new Vector2(
          speed.x * inputX,
          speed.y * inputY);

    }

    void FixedUpdate()
    {
        // 5 - перемещение игрового объекта
        GetComponent<Rigidbody2D>().velocity = movement;
    }

    void onCollision2D(Collision2D col)
    {


      if (col.gameObject.tag == "enemydemo")
        { Application.LoadLevel("MainMenu"); }
        
    }
}