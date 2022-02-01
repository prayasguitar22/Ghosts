using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostaddforce : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity=(new Vector2(-force,0));
    }
}
