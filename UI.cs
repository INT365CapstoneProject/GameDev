using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour

{
    public GameObject UIMenu;
    public GameObject BackTomenu;
    bool timestop = false;
    public GameObject cam;
    public GameObject textstop;
    
    public void Update()
    {
        if(timestop == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                textstop.SetActive(true);
                timestop = true;
                Time.timeScale = 0;
                BackTomenu.SetActive(true);
            }
        }
        else if (timestop == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                textstop.SetActive(false);
                timestop = false;
                Time.timeScale = 1;
                BackTomenu.SetActive(false);
            }
        }


    }
    public void Start()
    {
        Time.timeScale = 0;
    }
    public void StartGame()
    {
        Time.timeScale = 1;
       
        UIMenu.SetActive(false);
        
    }

    public void quiz()
    {
        Application.Quit();
    }

    // Update is called once per frame
    public void BackToMenu()
    {
        Time.timeScale = 0;
        textstop.SetActive(false);
        UIMenu.SetActive(true);
        BackTomenu.SetActive(false);
    }
}
