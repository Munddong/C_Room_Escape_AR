using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MurderFirstNarration : MonoBehaviour
{
    private AudioSource audioSource; // 카세트
    public AudioClip keyboard; // 키보드 소리
    public AudioClip murderBGM; // 살인방 음악
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
        firstNarrationText.DOText("여기가 어디지....? 이마에 통증이 있어 만져보니 마른 핏자국이 있다.\n핏자국을 지우고 보니 눈 앞에 낡은 파일철이 보인다.", 9.0f);
        audioSource.clip = keyboard; // 짧은 소리, 노래는 Play()로;
        audioSource.Play(); // 채팅 타자소리
        yield return new WaitForSeconds(9.0f);
        audioSource.Stop();
        firstNarrationBox.SetActive(false);
    }
}
