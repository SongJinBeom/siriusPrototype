using UnityEngine;
using System.Collections;

public class move : MonoBehaviour
{

    private float Speed;
    Vector2 MousePosition;

    void Start()
    {
        Speed = 4.1f;
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MousePosition = Input.mousePosition;

            if (MousePosition.x > 500)
            {
                GetComponent<Rigidbody2D>().AddForce(Vector2.right * Speed);
            }
            else
            {
                GetComponent<Rigidbody2D>().AddForce(Vector2.left * Speed);
            }
        }
        
    }
}


