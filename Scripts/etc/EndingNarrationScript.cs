using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class EndingNarrationScript : MonoBehaviour
{
    public GameObject endingNarrationBox;
    public Text endingNarrationText;

    public GameObject roomEscapeText;

    private AudioSource audioSource; // 카세트
    public AudioClip doorSlam;
    public AudioClip endingBgm;

    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();

        StartCoroutine(StartDialogue());
    }

    void Update()
    {

    }
    IEnumerator StartDialogue()
    {
        audioSource.clip = endingBgm;
        audioSource.Play();

        endingNarrationText.text = "";
        endingNarrationBox.SetActive(true);

        endingNarrationText.DOText("끼이익.....\n의문의 남성 : ··········", 4.0f);
        yield return new WaitForSeconds(4.0f);

        endingNarrationText.text = "";
        endingNarrationText.DOText("의문의 남성 : 셋 모두 방을 탈출하면서 너희들의 잘못을 알았을거야.\n어이가 없겠지.. 나는 더 어이가 없거든.\n너희들이 또 다른방에 갇힌이유를 알려줄까?", 12.0f);
        yield return new WaitForSeconds(12.0f);

        endingNarrationText.text = "";
        endingNarrationText.DOText("너희 셋의 부도덕, 부주의, 무관심한\n행동으로 인해 두 생명이 죽었다.\n내가 경찰일을 오래 하면서 느낀게 하나 있어.", 12.0f);
        yield return new WaitForSeconds(12.0f);

        endingNarrationText.text = "";
        endingNarrationText.DOText("경찰 : 너네 처럼 x같은 씨x 쓰레기 새x들은 쉽게 변하지 않아.\n임산부... 아니.. 내 아내와 아이를 죽인 것은\n어떤 것으로도 용서를 받을 수 없어...", 12.0f);
        yield return new WaitForSeconds(12.0f);

        endingNarrationText.text = "";
        endingNarrationText.DOText("내 슬픔과 분노를 그대로 느낄순 없겠지만,\n평생 그 곳에서 내 아내와 아이에게\n속죄하며 고통을 느껴봐...", 12.0f);
        yield return new WaitForSeconds(12.0f);

        endingNarrationText.text = "";
        yield return new WaitForSeconds(0.1f);

        audioSource.Stop();
        audioSource.clip = doorSlam;
        audioSource.Play();
        roomEscapeText.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        audioSource.Stop();

        SceneManager.LoadScene("EndRestartScene");
    }
}