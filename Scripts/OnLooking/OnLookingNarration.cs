using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class OnLookingNarration : MonoBehaviour
{
    private bool first_bool = false; // 첫 번째 버튼 bool값
    private bool second_bool = false;
    private bool third_bool = false;
    private bool fourth_bool = false;
    private bool fifth_bool = false;
    private bool sixth_bool = false;
    private bool seventh_bool = false;

    public GameObject first_BT; // 첫 번째 버튼
    public GameObject second_BT;
    public GameObject third_BT;
    public GameObject fourth_BT;
    public GameObject fifth_BT;
    public GameObject sixth_BT;
    public GameObject seventh_BT;

    public GameObject deskImageBox;
    public Text deskText;

    public GameObject bookImageBox;
    public Text bookText;

    public GameObject laptopImageBox;
    public Text laptopText;

    public GameObject headphoneImageBox;
    public Text headphoneText;

    public GameObject trashcanImageBox;
    public Text trashcanText;

    public GameObject cameraImageBox;
    public Text cameraText;

    public GameObject newspaperImageBox;
    public Text newspaperText;

    public GameObject exceptionBox;
    public Text exceptionText;

    public GameObject lastNarrationBox;

    private int randomException; // 예외 랜덤 문구

    void Start()
    {
        PlayerPrefs.SetInt("set", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("set") == 0)
        {
            if (first_bool == true)
            {
                PlayerPrefs.SetInt("set", 1);
                Destroy(first_BT);
                StartCoroutine(Desk());
            }

            if (second_bool == true)
            {
                second_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(BookException());
            }

            if (third_bool == true)
            {
                third_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(LapTopException());
            }

            if (fourth_bool == true)
            {
                fourth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(HeadphoneException());
            }

            if (fifth_bool == true)
            {
                fifth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(TrashCanException());
            }

            if (sixth_bool == true)
            {
                sixth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(CameraException());
            }

            if (seventh_bool == true)
            {
                seventh_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(NewspaperException());
            }
        }

        if (PlayerPrefs.GetInt("set") == 1)
        {
            if (second_bool == true)
            {
                PlayerPrefs.SetInt("set", 2);
                Destroy(second_BT);
                StartCoroutine(Book());
            }

            if (third_bool == true)
            {
                third_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(LapTopException());
            }

            if (fourth_bool == true)
            {
                fourth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(HeadphoneException());
            }

            if (fifth_bool == true)
            {
                fifth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(TrashCanException());
            }

            if (sixth_bool == true)
            {
                sixth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(CameraException());
            }

            if (seventh_bool == true)
            {
                seventh_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(NewspaperException());
            }
        }

        if (PlayerPrefs.GetInt("set") == 2)
        {
            if (third_bool == true)
            {
                PlayerPrefs.SetInt("set", 3);
                Destroy(third_BT);
                StartCoroutine(LapTop());
            }

            if (fourth_bool == true)
            {
                fourth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(HeadphoneException());
            }

            if (fifth_bool == true)
            {
                fifth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(TrashCanException());
            }

            if (sixth_bool == true)
            {
                sixth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(CameraException());
            }

            if (seventh_bool == true)
            {
                seventh_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(NewspaperException());
            }
        }

        if (PlayerPrefs.GetInt("set") == 3)
        {
            if (fourth_bool == true)
            {
                PlayerPrefs.SetInt("set", 4);
                Destroy(fourth_BT);
                StartCoroutine(Headphone());
            }

            if (fifth_bool == true)
            {
                fifth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(TrashCanException());
            }

            if (sixth_bool == true)
            {
                sixth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(CameraException());
            }

            if (seventh_bool == true)
            {
                seventh_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(NewspaperException());
            }
        }

        if (PlayerPrefs.GetInt("set") == 4)
        {
            if (fifth_bool == true)
            {
                PlayerPrefs.SetInt("set", 5);
                Destroy(fifth_BT);
                StartCoroutine(TrashCan());
            }

            if (sixth_bool == true)
            {
                sixth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(CameraException());
            }

            if (seventh_bool == true)
            {
                seventh_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(NewspaperException());
            }
        }

        if (PlayerPrefs.GetInt("set") == 5)
        {
            if (sixth_bool == true)
            {
                PlayerPrefs.SetInt("set", 6);
                Destroy(sixth_BT);
                StartCoroutine(Camera());
            }

            if (seventh_bool == true)
            {
                seventh_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(NewspaperException());
            }
        }

        if (PlayerPrefs.GetInt("set") == 6)
        {
            if (seventh_bool == true)
            {
                PlayerPrefs.SetInt("set", 7);
                seventh_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(Newspaper());
            }
        }
    }

    public void First_True() 
    {
        first_bool = true;
    }

    public void First_False()
    {
        first_bool = false;
    }

    public void Second_True()
    {
        second_bool = true;
    }

    public void Second_False()
    {
        second_bool = false;
    }

    public void Third_True()
    {
        third_bool = true;
    }

    public void Third_False()
    {
        third_bool = false;
    }

    public void Fourth_True()
    {
        fourth_bool = true;
    }

    public void Fourth_False()
    {
        fourth_bool = false;
    }

    public void Fifth_True()
    {
        fifth_bool = true;
    }

    public void Fifth_False()
    {
        fifth_bool = false;
    }

    public void Sixth_True()
    {
        sixth_bool = true;
    }

    public void Sixth_False()
    {
        sixth_bool = false;
    }

    public void Seventh_True()
    {
        seventh_bool = true;
    }

    public void Seventh_False()
    {
        seventh_bool = false;
    }

    IEnumerator Desk()
    {
        deskImageBox.SetActive(true);
        deskText.DOText("먼저 책상을 보니 비밀번호가 걸린 노트북이 보인다.\n아직은 풀 수 없을 것 같다.\n옆에 꽃혀 있는 책들부터 살펴보자.", 8.0f); // 채팅
        yield return new WaitForSeconds(8.0f);
    }

    IEnumerator Book()
    {
        bookImageBox.SetActive(true);
        bookText.DOText("책꽂이에 있는 책 한 권이 눈에 띈다.\n책의 목차를 살펴보니 빨간색 동그라미로 쳐진 곳이 보인다.\n⑤ 침묵 - 168p ⑦ 무관심 - 385p  ", 8.0f); // 채팅
        yield return new WaitForSeconds(8.0f);
    }

    IEnumerator LapTop()
    {
        laptopImageBox.SetActive(true);
        laptopText.DOText("노트북 비밀번호가 6자리 였던 것 같은데...\n1..6..8..3..8..5 '띠링' 소리 파일이 정지 되어 있다.\n옆에 헤드셋을 통해서 들어보자.", 8.0f); // 채팅
        yield return new WaitForSeconds(8.0f);
    }

    IEnumerator Headphone()
    {
        headphoneImageBox.SetActive(true);
        headphoneText.DOText("찰칵! ~ 찰칵! ~ 찰칵!\n3초간 주기로 찰칵소리가 3번들리고 파일이 끝났다.\n카메라에 관련된 것 같다. 카메라를 찾아보자.", 8.0f); // 채팅
        yield return new WaitForSeconds(8.0f);
    }
    IEnumerator TrashCan()
    {
        trashcanImageBox.SetActive(true);
        trashcanText.DOText("아무리 찾아봐도 카메라가 보이지 않는다.\n화가나서 쓰레기통을 발로 차보니 묵직한 것이 느껴진다.\n휴지통을 살펴보니 애타게 찾던 카메라가 보인다.", 8.0f); // 채팅
        yield return new WaitForSeconds(8.0f);
    }

    IEnumerator Camera()
    {
        cameraImageBox.SetActive(true);
        cameraText.DOText("카메라안에 사진첩을 보니 신문 사진과\n몇 개의 교통사고가난 현장 사진이 있다.\n어딘가 낯이 익다. 신문을 찾아보자.", 8.0f); // 채팅
        yield return new WaitForSeconds(8.0f);
    }

    IEnumerator Newspaper()
    {
        newspaperImageBox.SetActive(true);
        newspaperText.DOText("책꽂이 에서 신문을 찾고, 내용을 훑어 본다.\n'2018년 12월 xx일 월요일' 크리스마스 이브의 비극\n혈중 알코올 농도 0.25%, 만취 남성 임산부 덮쳐\n임산부와 아기 모두 사망.", 8.0f); // 채팅
        yield return new WaitForSeconds(8.0f);
        lastNarrationBox.SetActive(true);
    }

    public IEnumerator BookException()
    {
        exceptionText.text = "";
        exceptionBox.SetActive(true);
        Random_Cnt();
        yield return new WaitForSeconds(5.0f);
        exceptionBox.SetActive(false);
        second_BT.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    IEnumerator LapTopException()
    {
        exceptionText.text = "";
        exceptionBox.SetActive(true);
        Random_Cnt();
        yield return new WaitForSeconds(5.0f);
        exceptionBox.SetActive(false);
        third_BT.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    IEnumerator HeadphoneException()
    {
        exceptionText.text = "";
        exceptionBox.SetActive(true);
        Random_Cnt();
        yield return new WaitForSeconds(5.0f);
        exceptionBox.SetActive(false);
        fourth_BT.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    IEnumerator TrashCanException()
    {
        exceptionText.text = "";
        exceptionBox.SetActive(true);
        Random_Cnt();
        yield return new WaitForSeconds(5.0f);
        exceptionBox.SetActive(false);
        fifth_BT.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    IEnumerator CameraException()
    {
        exceptionText.text = "";
        exceptionBox.SetActive(true);
        Random_Cnt();
        yield return new WaitForSeconds(5.0f);
        exceptionBox.SetActive(false);
        sixth_BT.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    IEnumerator NewspaperException()
    {
        exceptionText.text = "";
        exceptionBox.SetActive(true);
        Random_Cnt();
        yield return new WaitForSeconds(5.0f);
        exceptionBox.SetActive(false);
        seventh_BT.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    void Random_Cnt()
    {
        randomException = Random.Range(0, 4);

        if (randomException == 0)
        {
            exceptionText.DOText("다른 것들을 먼저 찾아보자.", 4.0f); // 채팅
        }

        if (randomException == 1)
        {
            exceptionText.DOText("아직은 필요없는 물건으로 보인다.", 4.0f); // 채팅
        }

        if (randomException == 2)
        {
            exceptionText.DOText("지금 당장 필요한 것 부터 찾아보자.", 4.0f); // 채팅
        }

        if (randomException == 3)
        {
            exceptionText.DOText("이건 뭐지? 시간이 흘러가고 있어..", 4.0f); // 채팅
        }
    }
}