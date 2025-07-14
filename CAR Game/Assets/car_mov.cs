using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_mov : MonoBehaviour
{
    public int Speed = 5;
    public int boost = 10;

    void Start()
{
        enabled = false;
}


    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, 0, boost * Time.deltaTime);
        }
    }
}
