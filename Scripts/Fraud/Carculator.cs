using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Carculator : MonoBehaviour // 계산기 구현
{
    public Text TextUI;
    public static string text = null;
    float timer = 0;
    int waitingTime = 2;

    void Start()
    {

    }

    void Update()
    {
        timer += Time.deltaTime;

        TextUI.text = text;

        if (text.Length == 4)
        {
            if (text == "1074")
            {
                TextUI.text = "SUCCESS!";
                PlayerPrefs.SetInt("success", 1);
                PlayerPrefs.SetInt("Fraud", 1);

                if (timer >= waitingTime)
                {
                    if(PlayerPrefs.GetInt("success") == 1)
                   
                    timer = 0;
                }
                    
            }
            else
                TextUI.text = "Failed";
        }

        if (text.Length > 4)
            TextUI.text = "Failed";
    }

    public void BT0() { text += "0"; }
    public void BT1() { text += "1"; }
    public void BT2() { text += "2"; }
    public void BT3() { text += "3"; }
    public void BT4() { text += "4"; }
    public void BT5() { text += "5"; }
    public void BT6() { text += "6"; }
    public void BT7() { text += "7"; }
    public void BT8() { text += "8"; }
    public void BT9() { text += "9"; }
    public void Ba() { text = text.Substring(0, text.Length - 1); }
    public void Cl() { text = null; }
}
