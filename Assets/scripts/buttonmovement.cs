using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class buttonmovement : MonoBehaviour
{
    float diry;
    public int runspeed;
    public Rigidbody2D rigidbodi;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        diry = CrossPlatformInputManager.GetAxis("Vertical");
    }
    public void FixedUpdate()
    {
        rigidbodi.velocity = new Vector2(0f, diry * runspeed);
    }


}
