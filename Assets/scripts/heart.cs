using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class heart : MonoBehaviour
{public int health=3;
    public GameObject[] gameObjects;
    public Animator anim;
    public bool isshake;
    public GameObject healthffect;
    public GameObject deatheffect;
    public GameObject deathpanel;
    public GameObject normalpanel;
    public GameObject spellcollisioneffect;
    public GameObject healtheffect;
    public GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
        deathpanel.SetActive(false);
        normalpanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        if (health==3)
        {
            gameObjects[0].SetActive(true);
            gameObjects[1].SetActive(true);
            gameObjects[2].SetActive(true);
        }
        else if (health==2)
        {
            gameObjects[0].SetActive(true);
            gameObjects[1].SetActive(true);
            gameObjects[2].SetActive(false);
        }
        else if (health == 1)
        {
            gameObjects[0].SetActive(true);
            gameObjects[1].SetActive(false);
            gameObjects[2].SetActive(false);
        }
        else if (health == 0) 
        {
            Time.timeScale = 1f;
            Instantiate(deatheffect, transform.position, transform.rotation);
            deathpanel.SetActive(true);
            gameObject.SetActive(false);
            normalpanel.SetActive(false);
            spawner.SetActive(false);
        }
    }
        
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ghost"))
        {
           health--;
           anim.SetTrigger("shake");
           Instantiate(spellcollisioneffect, transform.position, transform.rotation);
           
        }

        else if (collision.CompareTag("Respawn") && health<3)
        {
            health++;
            Destroy(collision.gameObject);
            Instantiate(healthffect, transform.position, transform.rotation);
            Instantiate(healtheffect, transform.position, transform.rotation);
        }
        else if (collision.CompareTag("Respawn"))
        {
            Destroy(collision.gameObject);
            Instantiate(healthffect, transform.position, transform.rotation);
            Instantiate(healtheffect, transform.position, transform.rotation);
        }

    }
    }



