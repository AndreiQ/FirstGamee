using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce;
    public float backwardsForce;
    public float sidewaysForce;

    // Update is called once per frame
    void FixedUpdate()
    {

        pcControllers();
        androidControllers();
    }

    private void androidControllers()
    {
          transform.Translate(Input.acceleration.x , 0, -Input.acceleration.z);
    }

    private void pcControllers()
    {

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -backwardsForce * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
        checkGameOver();
    }
    private void checkGameOver()
    {
        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
