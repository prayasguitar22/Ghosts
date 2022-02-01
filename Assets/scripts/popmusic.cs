using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popmusic : MonoBehaviour
{
    public GameObject Popsound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void popsound()
    {
        Instantiate(Popsound, transform.position, transform.rotation);
    }

}
