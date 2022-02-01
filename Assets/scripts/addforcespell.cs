using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addforcespell : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float force;
    public GameObject Particle;
    public GameObject soundeffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity = (new Vector2(force, 0));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ghost"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Instantiate(Particle,transform.position,transform.rotation);
            Instantiate(soundeffect, transform.position, transform.rotation);
        }
    }
}
