using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spell : MonoBehaviour
{
    public GameObject spells;
    public float speed;
    public Rigidbody2D rigidbody;
    public GameObject particles;
    public int Numberofspell;
    public Text spellnumber;
    public bool isspell;
    public Animator anim;
    public GameObject spellsound;

    // Start is called before the first frame update
    void Start()
    {
        Numberofspell = Random.Range(4, 10);
    }

    // Update is called once per frame
    void Update()
    {
        spellnumber.text = Numberofspell.ToString();
        if (Numberofspell > 0)
        {
            shoot();
        }
        rigidbody.AddForce(Vector2.right * speed);
    }
    public void shoot()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(spells, transform.position, transform.rotation);
            Instantiate(particles, transform.position, transform.rotation);
            Numberofspell--;
            anim.SetTrigger("spell");
            Instantiate(spellsound, transform.position, transform.rotation);
        }
    }
}
