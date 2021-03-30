using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomSelect : MonoBehaviour
{
    public GameObject murder;
    public GameObject fraud;
    public GameObject onLooking;

    public GameObject murderText;
    public GameObject fraudText;
    public GameObject onLookingText;

    // Start is called before the first frame update
    void Start()
    {  
        if (PlayerPrefs.GetInt("Murder") == 0)
        {
            murder.SetActive(true);
            murderText.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Fraud") == 0)
        {
            fraud.SetActive(true);
            fraudText.SetActive(true);
        }

        if (PlayerPrefs.GetInt("OnLooking") == 0)
        {
            onLooking.SetActive(true);
            onLookingText.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Murder") == 1)
        {
            murder.SetActive(false);
            murderText.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Fraud") == 1)
        {
            fraud.SetActive(false);
            fraudText.SetActive(false);
        }

        if (PlayerPrefs.GetInt("OnLooking") == 1)
        {
            onLooking.SetActive(false);
            onLookingText.SetActive(false);
        }
    }

    public void Murder()
    {
        SceneManager.LoadScene("MurderRoom");
    }
    public void Fraud()
    {
        SceneManager.LoadScene("FraudRoom");
    }
    public void OnLooking()
    {
        SceneManager.LoadScene("OnLookingRoom");
    }
}
