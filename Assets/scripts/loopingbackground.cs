using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopingbackground : MonoBehaviour
{
    public float backgroundspeed;
    public float startx;
    public float endx;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * backgroundspeed * Time.deltaTime);
        if (transform.position.x <= endx)
        {
            
            Vector2 pos= new Vector2(startx ,transform.position.y);
            transform.position = pos;
        }
    }
}
