using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour // 남은 시간 표시
{
    private float time_cnt;
    private float time_last;

    public Text time_text;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("success", 0);
    }

    // Update is called once per frame
    void Update()
    {
        time_cnt += Time.deltaTime;

        time_last = 600.0f - time_cnt;

        time_text.text = "남은 시간 : " + ((int)(time_last / 60) + "분"+   (int)(time_last % 60) + "초");

        if (time_last >= 0)
        {
            if (PlayerPrefs.GetInt("success") == 1)
            {
                SceneManager.LoadScene("DoorOpen");
            }
        }
        else if (time_last <= 0)
        {
            SceneManager.LoadScene("TimeOutScene");
        }
        PlayerPrefs.SetInt("success", 0);
    }
}
