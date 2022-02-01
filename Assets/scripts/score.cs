using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public int sore;
    public Text text;
    public Text highsscore;
    public Text deadscore;
    public int highscore;
    private int plus;
    public GameObject player;

    private void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore",sore);
    }
    // Update is called once per frame
    void Update()
    {
        text.text = sore.ToString();
        highsscore.text = highscore.ToString();
        deadscore.text = sore.ToString();

        if (highscore < sore)
        {
            PlayerPrefs.SetInt("highscore", sore);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (player.active==true)
        {
            if (other.CompareTag("ghost"))
            {
                plus = Random.Range(1, 3);
                sore += plus;
                Destroy(other.gameObject);
            }
            if (other.CompareTag("Respawn"))
            {
                Destroy(other.gameObject);
            }
        }

        if (other.CompareTag("ghost"))
        {
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Respawn"))
        {
            Destroy(other.gameObject);
        }
    }
}
