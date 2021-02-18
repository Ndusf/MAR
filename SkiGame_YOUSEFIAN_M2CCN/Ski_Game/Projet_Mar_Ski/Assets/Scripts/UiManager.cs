using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UiManager : MonoBehaviour
{
    //Public Variable
    public Text txtObstacle;
    public Text txtcountObstace;
    public GameObject panelButton;
    public Text txtTime;
    public Text txtStopTime;
    //Private Varible
    private int countObstacle;
    private SceneLoader sceneLoader;
    private int time;
    private int s, m;
    //Private Method
    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
        s = 0;
        m = 0;
        InvokeRepeating("GetTime",0,1);
    }
    private void Update()
    {
        //time =(int) Time.time;
        //txtTime.text = "Time :" + time;
        txtStopTime.text = "Time " + m + " :" + s;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            panelButton.SetActive(true);
            txtObstacle.enabled = false;
            txtTime.enabled = false;
        }
    }

    //Public Method
    public void GetObstacle()
    {
        countObstacle++;
        txtObstacle.text ="Obstacle :"+ countObstacle;
        txtcountObstace.text = "Obstacle :" + countObstacle;
    }
    public void ResumeGame()
    {
        
        Time.timeScale = 1;
        panelButton.SetActive(false);
        txtObstacle.enabled = true;
        txtTime.enabled = true;
    }
    public void Resetgame()
    {
        Time.timeScale = 1;
        sceneLoader.ResetGame();
        txtObstacle.enabled = true;
        txtTime.enabled = true;
    }
    public void MenuGame()
    {
        Time.timeScale = 1;
        sceneLoader.LoadScene("Main");
        txtObstacle.enabled = true;
        txtTime.enabled = true;
    }
    private void GetTime()
    {
        s++;
        if(s == 59)
        {
            s = 0;
            m++;
        }
        txtTime.text ="Time  " + m + " :" + s;
    }
}
