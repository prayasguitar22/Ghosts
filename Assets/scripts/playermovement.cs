using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody2D body;

    float vertical;

    public float runSpeed = 20.0f;

    void Start()
    {

    }

    void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");
    }

    public void FixedUpdate()
    {
        body.velocity = new Vector2(0, vertical * runSpeed);
    }
}
