using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    float movementX;
    public float velocity = 40f;
    public Rigidbody2D rb;
    public float jumpForce = 4f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movementX = Input.GetAxis("Horizontal");
        print(movementX);

    }

}