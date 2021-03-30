using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class OnLookingFirstNarration : MonoBehaviour
{
    private AudioSource audioSource; // 카세트
    public AudioClip keyboard; //키보드 소리

    public Text firstNarrationText; // 나래이션 텍스트
    public GameObject firstNarrationBox; // 나래이션 박스

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(StartDialogue());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator StartDialogue()
    {
        firstNarrationText.text = "";
        firstNarrationBox.SetActive(true);
        firstNarrationText.DOText("어두운 곳에서 빛을 따라 눈을 떴다.\n눈을 비비고 주변을 둘러보자...", 9.0f);
        audioSource.clip = keyboard; // 짧은 소리, 노래는 Play()로;
        audioSource.Play(); // 채팅 타자소리
        yield return new WaitForSeconds(9.0f);
        audioSource.Stop();
        firstNarrationBox.SetActive(false);
    }
}
