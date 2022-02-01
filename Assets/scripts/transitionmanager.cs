using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transitionmanager : MonoBehaviour
{   public Animator anim;
    public int ID;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            StartCoroutine(LoadScene());
        }
    }
    IEnumerator LoadScene()
    {
        anim.SetTrigger("end");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(ID);


    }
}
