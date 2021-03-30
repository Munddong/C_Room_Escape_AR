using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class FraudNarration : MonoBehaviour
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

    public GameObject MirrorImageBox; // 파일 채팅 박스
    public Text MirrorText; // 파일 텍스트

    public GameObject CellPhoneImageBox;
    public Text CellPhoneText;

    public GameObject BallPointPenImageBox; // 파일 채팅 박스
    public Text BallPointPenText;

    public GameObject PaperImageBox;
    public Text PaperText;

    public GameObject CreditCardImageBox;
    public Text CreditCardText;

    public GameObject BillImageBox;
    public Text BillText;

    public GameObject BankBookImageBox;
    public Text BankBookText;

    public GameObject exceptionBox;
    public Text exceptionText;

    public GameObject lastNarrationBox;

    private int randomException; // 예외 랜덤 문구
    private float timer;

    void Start()
    {
        PlayerPrefs.SetInt("set", 0);
    }

    // Update is called once per frame
    void Update() // 방탈출의 순서 알고리즘(ex. 순서대로 힌트를 찾아야 다음 플레이가 가능)
    {
        if (PlayerPrefs.GetInt("set") == 0)
        {
            if (first_bool == true)
            {
                PlayerPrefs.SetInt("set", 1);
                Destroy(first_BT);
                StartCoroutine(Mirror());
            }

            if (second_bool == true)
            {
                second_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(CellPhoneException());
            }

            if (third_bool == true)
            {
                third_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(BallPointPenException());
            }

            if (fourth_bool == true)
            {
                fourth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(PaperException());
            }

            if (fifth_bool == true)
            {
                fifth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(CreditCardException());
            }

            if (sixth_bool == true)
            {
                sixth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(BillException());
            }

            if (seventh_bool == true)
            {
                seventh_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(BankBookException());
            }
        }

        if (PlayerPrefs.GetInt("set") == 1)
        {
            if (second_bool == true)
            {
                PlayerPrefs.SetInt("set", 2);
                Destroy(second_BT);
                StartCoroutine(CellPhone());
            }

            if (third_bool == true)
            {
                third_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(BallPointPenException());
            }

            if (fourth_bool == true)
            {
                fourth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(PaperException());
            }

            if (fifth_bool == true)
            {
                fifth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(CreditCardException());
            }

            if (sixth_bool == true)
            {
                sixth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(BillException());
            }

            if (seventh_bool == true)
            {
                seventh_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(BankBookException());
            }
        }

        if (PlayerPrefs.GetInt("set") == 2)
        {
            if (third_bool == true)
            {
                PlayerPrefs.SetInt("set", 3);
                Destroy(third_BT);
                StartCoroutine(BallPointPen());
            }

            if (fourth_bool == true)
            {
                fourth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(PaperException());
            }

            if (fifth_bool == true)
            {
                fifth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(CreditCardException());
            }

            if (sixth_bool == true)
            {
                sixth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(BillException());
            }

            if (seventh_bool == true)
            {
                seventh_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(BankBookException());
            }
        }

        if (PlayerPrefs.GetInt("set") == 3)
        {
            if (fourth_bool == true)
            {
                PlayerPrefs.SetInt("set", 4);
                Destroy(fourth_BT);
                StartCoroutine(Paper());
            }

            if (fifth_bool == true)
            {
                fifth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(CreditCardException());
            }

            if (sixth_bool == true)
            {
                sixth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(BillException());
            }

            if (seventh_bool == true)
            {
                seventh_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(BankBookException());
            }
        }

        if (PlayerPrefs.GetInt("set") == 4)
        {
            if (fifth_bool == true)
            {
                PlayerPrefs.SetInt("set", 5);
                Destroy(fifth_BT);
                StartCoroutine(CreditCard());
            }

            if (sixth_bool == true)
            {
                sixth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(BillException());
            }

            if (seventh_bool == true)
            {
                seventh_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(BankBookException());
            }
        }

        if (PlayerPrefs.GetInt("set") == 5)
        {
            if (sixth_bool == true)
            {
                PlayerPrefs.SetInt("set", 6);
                Destroy(sixth_BT);
                StartCoroutine(Bill());
            }

            if (seventh_bool == true)
            {
                seventh_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(BankBookException());
            }
        }

        if (PlayerPrefs.GetInt("set") == 6)
        {
            if (seventh_bool == true)
            {
                PlayerPrefs.SetInt("set", 7);
                seventh_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(BankBook());
            }
        }
    }

    public void First_True() {first_bool = true;}
    public void First_False() {first_bool = false;}
    public void Second_True() {second_bool = true;}
    public void Second_False() {second_bool = false;}
    public void Third_True() {third_bool = true;}
    public void Third_False() {third_bool = false;}
    public void Fourth_True() {fourth_bool = true;}
    public void Fourth_False() {fourth_bool = false;}
    public void Fifth_True() {fifth_bool = true;}
    public void Fifth_False() {fifth_bool = false;}
    public void Sixth_True() {sixth_bool = true;}
    public void Sixth_False() {sixth_bool = false;}
    public void Seventh_True() {seventh_bool = true;}
    public void Seventh_False() {seventh_bool = false;}

    //내용
    IEnumerator Mirror()
    {
        MirrorImageBox.SetActive(true);
        MirrorText.DOText(" 으.. 머리아파. 거울을 보니 평소에 단정하던\n내 얼굴이 아닌 덥수룩한 수염이 보인다.\n내가 낯설어 보인다.. 거울옆에 빨간색 글씨가 보인다. 12", 10.0f); // 채팅
        yield return new WaitForSeconds(10.0f);
    }
    IEnumerator CellPhone()
    {
        CellPhoneImageBox.SetActive(true);
        CellPhoneText.DOText("'띠리링 띠리링', 휴대폰에 메시지 1통이 와있다.\n배터리가 별로 없으니 메시지를 적어두자.", 8.0f); // 채팅
        yield return new WaitForSeconds(8.0f);
    }
    IEnumerator BallPointPen()
    {
        BallPointPenImageBox.SetActive(true);
        BallPointPenText.DOText("1 * 1 ㅁ 1 = 0\n4 ㅁ 2 + 3 = 11\n13 * 3 - 3 ㅁ 6 = 42\n아무래도 네모안에 들어갈 것은 기호인 것 같다.", 10.0f); // 채팅
        yield return new WaitForSeconds(10.0f);
    }
    IEnumerator Paper()
    {
        PaperImageBox.SetActive(true);
        PaperText.DOText("주위에 낡은 종이가 있다. 한 번 적어보자.\n어디선가 이상한 냄새가 난다.\n냄새가 나는 곳에 한 번 가보자.", 8.0f); // 채팅
        yield return new WaitForSeconds(8.0f);
    }
    IEnumerator CreditCard()
    {
        CreditCardImageBox.SetActive(true);
        CreditCardText.DOText("박스주위에서 비린내가 진동한다. 박스를 열어보자.\n알수없는 이름의 신용카드와 통장이 보인다.\n먼저 살펴본 신용카드 뒷면 유효기간에 피가 묻어있다.\n피를 지워보자. '01 / 27'", 14.0f); // 채팅
        yield return new WaitForSeconds(8.0f);
    }
    IEnumerator Bill()
    {
        BillImageBox.SetActive(true);
        BillText.DOText("통장을 열자마자 5만원 지폐가 떨어진다.\n툭.. 안에 무언가가 들어있다.\n안에 들어 있는 것은 낡은 열쇠다.\n먼지가 쌓인 문 앞에 다가가 열쇠를 사용해본다.", 12.0f); // 채팅
        yield return new WaitForSeconds(12.0f);
    }
    IEnumerator BankBook()
    {
        BankBookImageBox.SetActive(true);
        BankBookText.DOText("힘을 주어 낡은 열쇠를 돌리는 순간 열쇠가 부러진다.\n 절망감을 안고 통장을 다시 살펴본다.\n예금주는 '나'이며, 계좌안엔 1억 가량의 돈이 들어있었다.\n내가 갇힌 이유를 알 것 같다...", 14.0f); // 채팅
        yield return new WaitForSeconds(14.0f);
        lastNarrationBox.SetActive(true);
    }

    //예외처리
    public IEnumerator CellPhoneException()
    {
        exceptionText.text = "";
        exceptionBox.SetActive(true);
        Random_Cnt();
        yield return new WaitForSeconds(5.0f);
        exceptionBox.SetActive(false);
        second_BT.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    IEnumerator BallPointPenException()
    {
        exceptionText.text = "";
        exceptionBox.SetActive(true);
        Random_Cnt();
        yield return new WaitForSeconds(5.0f);
        exceptionBox.SetActive(false);
        third_BT.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    IEnumerator PaperException()
    {
        exceptionText.text = "";
        exceptionBox.SetActive(true);
        Random_Cnt();
        yield return new WaitForSeconds(5.0f);
        exceptionBox.SetActive(false);
        fourth_BT.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    IEnumerator CreditCardException()
    {
        exceptionText.text = "";
        exceptionBox.SetActive(true);
        Random_Cnt();
        yield return new WaitForSeconds(5.0f);
        exceptionBox.SetActive(false);
        fifth_BT.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    IEnumerator BillException()
    {
        exceptionText.text = "";
        exceptionBox.SetActive(true);
        Random_Cnt();
        yield return new WaitForSeconds(5.0f);
        exceptionBox.SetActive(false);
        sixth_BT.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    IEnumerator BankBookException()
    {
        exceptionText.text = "";
        exceptionBox.SetActive(true);
        Random_Cnt();
        yield return new WaitForSeconds(5.0f);
        exceptionBox.SetActive(false);
        seventh_BT.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    void Random_Cnt() // 다른 힌트를 찾았을 때 랜덤 문구 생성
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