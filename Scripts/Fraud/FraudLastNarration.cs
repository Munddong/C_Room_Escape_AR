using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FraudLastNarration : MonoBehaviour
{
    private AudioSource audioSource; // 카세트
    public AudioClip keyboard; //키보드 소리

    public Text lastNarrationText;
    public GameObject lastNarrationBox;
    public GameObject[] objects;

    public GameObject Calculator;

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
        lastNarrationText.DOText("부러진 가짜 열쇠를 자세히 보니 숫자가 적혀있다.\n'777', 거울의 쓰인 12, 유효기간 01, 27,\n부러진 가짜열쇠의 777은 무엇을 의미할까?", 9.0f);
        audioSource.clip = keyboard; // 짧은 소리, 노래는 Play()로;
        audioSource.Play();
        yield return new WaitForSeconds(9.0f);
        audioSource.Stop();
        Calculator.SetActive(true);
    }
}
