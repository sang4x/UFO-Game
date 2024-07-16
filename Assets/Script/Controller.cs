using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rd;
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(horizontalInput,verticalInput);
        rd.AddForce(movement * speed);
    }
}
