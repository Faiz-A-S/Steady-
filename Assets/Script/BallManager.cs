using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    private Rigidbody ball;
    public Vector3 reset;

    private void Start()
    {
        ball = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Respawn")
        {
            ball.transform.position = reset; 
        }
    }
}
