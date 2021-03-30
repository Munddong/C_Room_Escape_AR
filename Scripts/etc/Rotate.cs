using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rotate : MonoBehaviour
{
    private Transform tr;
    public Transform target_tr;
    public float rot_speed = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.eulerAngles.x);
        tr.RotateAround(target_tr.position, Vector3.up, Time.deltaTime * rot_speed);

        if (transform.eulerAngles.y >= 45)
        {
            if ((PlayerPrefs.GetInt("Murder") == 1) && (PlayerPrefs.GetInt("Fraud") == 1) && (PlayerPrefs.GetInt("OnLooking") == 1))
            {
                SceneManager.LoadScene("HiddenScene");
            }

            else
                SceneManager.LoadScene("RoomSelect");
        }
    }
}