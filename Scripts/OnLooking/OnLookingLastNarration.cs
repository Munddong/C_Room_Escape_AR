using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class OnLookingLastNarration : MonoBehaviour
{
    private AudioSource audioSource; // 카세트
    public AudioClip keyboard; //키보드 소리
    public AudioClip doorOpen;

    public Text lastNarrationText;
    public GameObject lastNarrationBox;
    public GameObject[] objects;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(LastDialogue());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator LastDialogue()
    {
        objects[0].SetActive(false);
        objects[1].SetActive(false);
        objects[2].SetActive(false);
        objects[3].SetActive(false);
        objects[4].SetActive(false);
        objects[5].SetActive(false);
        objects[6].SetActive(false);
        lastNarrationText.text = "";
        lastNarrationBox.SetActive(true);
        lastNarrationText.DOText("신문을 다 읽고나니 열쇠가 떨어져 있다.\n열쇠를 문에 넣고 돌려보니 문이 열린다..", 5.0f);
        audioSource.clip = keyboard; // 짧은 소리, 노래는 Play()로;
        audioSource.Play();
        yield return new WaitForSeconds(5.0f);
        audioSource.Stop();
        audioSource.clip = doorOpen;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        PlayerPrefs.SetInt("success", 1);
        PlayerPrefs.SetInt("OnLooking", 1);
    }
}
