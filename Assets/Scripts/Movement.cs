using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class Movement : MonoBehaviour
{

    public float speed = 10;

    private Rigidbody rb;
    private float movementX;
    private float movementY;

    private ScoreScript scoreScript ;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        scoreScript = GetComponent<ScoreScript>();
    }


    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }


    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            scoreScript.Count(1);
        }
    }




}
