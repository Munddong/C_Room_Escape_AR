using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomEscapeButton : MonoBehaviour
{

    void Start()
    {
        PlayerPrefs.SetInt("Murder", 0);
        PlayerPrefs.SetInt("Fraud", 0);
        PlayerPrefs.SetInt("OnLooking", 0);
    }

    void Update()
    {

    }

    public void startButton()
    {
        SceneManager.LoadScene("RoomSelect");
    }

    public void exitButton() // 어플리케이션 종료 함수
    {
        Application.Quit();
    }

    public void Restart_Room()
    {
        SceneManager.LoadScene("RoomSelect");
    }

    public void Last()
    {
        SceneManager.LoadScene("RoomEscape");
    }
}
