using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{

    public float speed = 10;

    private Rigidbody rb;

    private Vector3 movement;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }








}
