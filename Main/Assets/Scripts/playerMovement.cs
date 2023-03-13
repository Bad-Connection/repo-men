using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    bool jump;
    int movement = 5000;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Rotate(Vector3.up, movement);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Rotate(Vector3.down, -movement);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(Vector3.left, -movement);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(Vector3.right, movement);
        }

        if (Input.GetKey(KeyCode.W))
        {
            jump = true;
            transform.Translate(0f, 0.01f, 0f); 
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, -0.01f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.01f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.01f, 0f, 0f);
        }

    }
}
