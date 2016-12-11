using System;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    bool paused = false;

    public GameObject pauseSign;

    void Start()
    {
        pauseSign.SetActive(false);
    }

    void Update()
    {
        if (Input.GetButtonDown("Pause"))
            paused = togglePause();
    }

    void OnGUI()
    {
        if (paused == true)
        {
            pauseSign.SetActive(true);
            
        }

        if (Input.GetButtonDown("Pause"))
        {
            paused = togglePause();
            pauseSign.SetActive(false);
        }
    }

    bool togglePause()
    {
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
            return (false);
        }
        else
        {
            Time.timeScale = 0f;
            return (true);
        }
    }
}