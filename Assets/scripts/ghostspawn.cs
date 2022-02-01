using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostspawn : MonoBehaviour
{   public float minx;
    public float maxx;
    public float miny;
    public float maxy;
    public float timebetweenspawn;
    public GameObject[] gameObjects;
    private GameObject gameObjecte;
    private float spawntime;
    public int range;
    public GameObject player;
    public float limittime;
    public float decresetime;

    private void Start()
    {
        spawntime = Time.time;
        timebetweenspawn = Random.Range(timebetweenspawn, range);
    }

    private void Update()
    {
        if (Time.time > spawntime)
        {
            spawntime += timebetweenspawn;
            spawn();

            if (spawntime >limittime ) 
            {
                spawntime -= decresetime;
            }
        }


    }

    
    void spawn()
    {
        if (player.active == true)
        {
            float randomx = Random.Range(maxx, maxy);
            float randomy = Random.Range(maxy, miny);
            int randomi = Random.Range(0, 6);
            gameObjecte = gameObjects[randomi];
            Instantiate(gameObjecte, transform.position + new Vector3(randomx, randomy, 0), transform.rotation);
        }
    }
}
