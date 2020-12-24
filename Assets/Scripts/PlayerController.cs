using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public bool IsPlayer1 = true;
    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if(IsPlayer1 == true)
        {
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    rb.MovePosition(rb.position + Vector2.up * Speed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    rb.MovePosition(rb.position + Vector2.down * Speed * Time.deltaTime);
                }
        }
        else
        {
                if (Input.GetKey(KeyCode.W))
                {
                    rb.MovePosition(rb.position + Vector2.up * Speed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.S))
                {
                    rb.MovePosition(rb.position + Vector2.down * Speed * Time.deltaTime);
                }

        }
    }

}
