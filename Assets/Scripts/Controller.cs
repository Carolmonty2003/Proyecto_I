using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float movementSpeed = 5;
    public float jumpForce = 300.0f;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    GetComponent<Rigidbody2D>().velocity = new Vector2(0,5);
        //}

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(2, 0));
            
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-2, 0));
            GetComponent<Rigidbody2D>().velocity = new Vector2(-2, 0);
            //transform.position += new Vector3(-1, 0, 0);
        }

        if (Input.GetButton("Jump"))
        {
            if (Input.GetButtonDown("Jump"))
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
            }

            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);
        }
        
    }
}
