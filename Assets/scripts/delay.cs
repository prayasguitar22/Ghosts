using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delay : MonoBehaviour
{
    public GameObject countdown;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine ("StartDelay");
    }

    IEnumerator StartDelay()
    {
        Time.timeScale = 0;
        float pauseTime = Time.realtimeSinceStartup + 3f;
        while (Time.realtimeSinceStartup < pauseTime)
        yield return 0;
        countdown.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
