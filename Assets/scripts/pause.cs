using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{   public GameObject pausemenu;
    public GameObject whatpanel;
    public Animator anim;
    public Animator countdownanim;
    public heart script;
    public GameObject countdown;
    public GameObject camera;
    public GameObject Sounddon;
    public GameObject Sounddoff;
   
    // Start is called before the first frame update
    void Start()
    {
        Sounddoff.SetActive(false);
        pausemenu.SetActive(false);
        whatpanel.SetActive(false);
        StartCoroutine("StartDelay");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        pausemenu.SetActive(true);
    }

     public void resume()
    {
        Time.timeScale = 1f;
        pausemenu.SetActive(false);
    }

     public void home()
     {
        anim.SetTrigger("end");
        Time.timeScale = 1f;
        StartCoroutine(LoadScene(0));
     }
     IEnumerator LoadScene(int ID)
     {
         yield return new WaitForSeconds(1f);
         SceneManager.LoadScene(ID);
     }
    IEnumerator delay ()
    {
        Time.timeScale = 1f;
        yield return new WaitForSeconds(3f);
        Time.timeScale = 1f;
    }


    public void restart()
    {
        anim.SetTrigger("end");
        StartCoroutine(LoadScene(1));
        Time.timeScale = 0f;
        countdownanim.SetTrigger("countdown");
        StartCoroutine(delay());
        script.normalpanel.SetActive(true);
        Time.timeScale = 1f;
    }

    public void what()
    {
        whatpanel.SetActive(true);
        pausemenu.SetActive(false);
    }
    public void back()
    {
        whatpanel.SetActive(false);
        pausemenu.SetActive(true);
    }

    public void play()
    {
        anim.SetTrigger("end");
        Time.timeScale = 1f;
        StartCoroutine(LoadScene(1));
    }
    public void AD()
    {
        script.health += 1;
        script.deathpanel.SetActive(false);
        script.gameObject.SetActive(true);
        Instantiate(script.deatheffect, transform.position, transform.rotation);
        script.normalpanel.SetActive(true);
        StartCoroutine("delay");

    }
    public void soundoff()
    {
        Sounddon.SetActive(false);
        Sounddoff.SetActive(true);
        camera.GetComponent<AudioListener>().enabled = false;
    }

    public void soundon()
    {
        Sounddon.SetActive(true);
        Sounddoff.SetActive(false);
        camera.GetComponent<AudioListener>().enabled = true;
    }

}
