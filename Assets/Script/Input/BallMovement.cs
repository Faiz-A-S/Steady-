using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallMovement : MonoBehaviour
{
    private Rigidbody bola;
    private PlayerInput playerInput;
    private MovementScript movementScript;
    public float speed;

    // Start is called before the first frame update
    void Awake()
    {
        bola = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();

        movementScript = new MovementScript();
        movementScript.Ball.Enable();
        movementScript.Ball.BallMovement.performed += Movement_Perform;
    }
    
    // Update is called once per frame
    private void FixedUpdate()
    {
        //read value from inputmanager and add force to ball
        Vector2 inputVdua = movementScript.Ball.BallMovement.ReadValue<Vector2>();
        bola.AddForce(new Vector3(inputVdua.x, 0, inputVdua.y) * speed, ForceMode.Force);
    }

    private void Movement_Perform(InputAction.CallbackContext context)
    {
        //Debug.Log("Test " + context);
    }
}
