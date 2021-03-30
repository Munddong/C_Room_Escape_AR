using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MurderNarration : MonoBehaviour
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

    public GameObject fileImageBox; // 파일 채팅 박스
    public Text fileText; // 파일 텍스트

    public GameObject monitorImageBox;
    public Text monitorText;

    public GameObject printerImageBox; // 파일 채팅 박스
    public Text printerText;

    public GameObject bloodyPantsImageBox;
    public Text bloodyPantsText;

    public GameObject carImageBox;
    public Text carText;

    public GameObject medicalChartImageBox;
    public Text medicalChartText;

    public GameObject liquorBottleImageBox;
    public Text liquorBottleText;

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
                StartCoroutine(FileFolder());
            }

            if (second_bool == true)
            {
                second_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(MonitorException());
            }

            if (third_bool == true)
            {
                third_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(PrinterException());
            }

            if (fourth_bool == true)
            {
                fourth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(BloodyPantsException());
            }

            if (fifth_bool == true)
            {
                fifth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(CarException());
            }

            if (sixth_bool == true)
            {
                sixth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(MedicalChartException());
            }

            if (seventh_bool == true)
            {
                seventh_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(LiquorBottleException());
            }
        }

        if (PlayerPrefs.GetInt("set") == 1)
        {
            if (second_bool == true)
            {
                PlayerPrefs.SetInt("set", 2);
                Destroy(second_BT);
                StartCoroutine(Monitor());
            }

            if (third_bool == true)
            {
                third_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(PrinterException());
            }

            if (fourth_bool == true)
            {
                fourth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(BloodyPantsException());
            }

            if (fifth_bool == true)
            {
                fifth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(CarException());
            }

            if (sixth_bool == true)
            {
                sixth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(MedicalChartException());
            }

            if (seventh_bool == true)
            {
                seventh_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(LiquorBottleException());
            }
        }

        if (PlayerPrefs.GetInt("set") == 2)
        {
            if (third_bool == true)
            {
                PlayerPrefs.SetInt("set", 3);
                Destroy(third_BT);
                StartCoroutine(Printer());
            }

            if (fourth_bool == true)
            {
                fourth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(BloodyPantsException());
            }

            if (fifth_bool == true)
            {
                fifth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(CarException());
            }

            if (sixth_bool == true)
            {
                sixth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(MedicalChartException());
            }

            if (seventh_bool == true)
            {
                seventh_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(LiquorBottleException());
            }
        }

        if (PlayerPrefs.GetInt("set") == 3)
        {
            if (fourth_bool == true)
            {
                PlayerPrefs.SetInt("set", 4);
                Destroy(fourth_BT);
                StartCoroutine(BloodyPants());
            }

            if (fifth_bool == true)
            {
                fifth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(CarException());
            }

            if (sixth_bool == true)
            {
                sixth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(MedicalChartException());
            }

            if (seventh_bool == true)
            {
                seventh_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(LiquorBottleException());
            }
        }

        if (PlayerPrefs.GetInt("set") == 4)
        {
            if (fifth_bool == true)
            {
                PlayerPrefs.SetInt("set", 5);
                Destroy(fifth_BT);
                StartCoroutine(Car());
            }

            if (sixth_bool == true)
            {
                sixth_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(MedicalChartException());
            }

            if (seventh_bool == true)
            {
                seventh_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(LiquorBottleException());
            }
        }

        if (PlayerPrefs.GetInt("set") == 5)
        {
            if (sixth_bool == true)
            {
                PlayerPrefs.SetInt("set", 6);
                Destroy(sixth_BT);
                StartCoroutine(MedicalChart());
            }

            if (seventh_bool == true)
            {
                seventh_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(LiquorBottleException());
            }
        }

        if (PlayerPrefs.GetInt("set") == 6)
        {
            if (seventh_bool == true)
            {
                PlayerPrefs.SetInt("set", 7);
                seventh_BT.transform.localScale = new Vector3(0f, 0f, 0f);
                StartCoroutine(LiquorBottle());
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

    IEnumerator FileFolder()
    {
        fileImageBox.SetActive(true);
        fileText.DOText("사건번호 #1225 / 2018년 12월 xx일 월요일 만취인 가해자\n임산부 피해자 치어 임산부 사망, 끔직한 사건사진이 보인다.\n지직... 모니터에서 소리가 들린다.", 8.0f); // 채팅
        yield return new WaitForSeconds(8.0f);
    }

    IEnumerator Monitor()
    {
        monitorImageBox.SetActive(true);
        monitorText.DOText("직.. 지지직... 모니터 앞에 희미한 불빛이 새어 나온다.\n모니터 옆에 프린터를 살펴 보자.", 8.0f); // 채팅
        yield return new WaitForSeconds(8.0f);
    }

    IEnumerator Printer()
    {
        printerImageBox.SetActive(true);
        printerText.DOText("프린터에 인쇄된 자동차 모형의 사진이 있다.\n자동차 모형을 찾아봐야 하지 않을까?\n숨겨져 있을 만한 곳을 찾아보자.", 8.0f); // 채팅
        yield return new WaitForSeconds(8.0f);
    }

    IEnumerator BloodyPants()
    {
        bloodyPantsImageBox.SetActive(true);
        bloodyPantsText.DOText("아까부터 눈에 띄는 큰 장농이 있다.\n끼이익... 누군가의 피가 잔뜩 묻어있는 옷이 보인다.\n주머니에 무언가가 들어 있다.", 8.0f); // 채팅
        yield return new WaitForSeconds(8.0f);
    }
    IEnumerator Car()
    {
        carImageBox.SetActive(true);
        carText.DOText("인쇄된 사진에서 본 장난감 자동차가 있다.\n자동차를 자세히 살펴보니 옆에 버튼이 있다.\n버튼을 누르니 툭... 떨어지는 소리가 난다. 소리가 나는 곳으로 가보자.", 8.0f); // 채팅
        yield return new WaitForSeconds(8.0f);
    }

    IEnumerator MedicalChart()
    {
        medicalChartImageBox.SetActive(true);
        medicalChartText.DOText("물건을 줍고 보니, 하얀 봉투의 병원 소견서가 적혀져 있다.\n낡아보이는 종이... 내용을 보니 알코올 중독 진단과\n우울증, 스트레스 장애 등이 적혀있다.\n글 뒤에 당구장표식이 있는데 무엇일까? 표식을 찾아보자.", 8.0f); // 채팅
        yield return new WaitForSeconds(8.0f);
    }

    IEnumerator LiquorBottle()
    {
        liquorBottleImageBox.SetActive(true);
        liquorBottleText.DOText("술병이 들어 있는 박스에서 당구장 표식을 발견했다.\n어...? 이건 내가 매일 먹던 소주병이다...\n내가 왜 갇힌지 알 것 같다. 손을 떨면서 소주병을 든다.", 8.0f); // 채팅
        yield return new WaitForSeconds(8.0f);
        lastNarrationBox.SetActive(true);
    }

    public IEnumerator MonitorException()
    {
        exceptionText.text = "";
        exceptionBox.SetActive(true);
        Random_Cnt();
        yield return new WaitForSeconds(5.0f);
        exceptionBox.SetActive(false);
        second_BT.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    IEnumerator PrinterException()
    {
        exceptionText.text = "";
        exceptionBox.SetActive(true);
        Random_Cnt();
        yield return new WaitForSeconds(5.0f);
        exceptionBox.SetActive(false);
        third_BT.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    IEnumerator BloodyPantsException()
    {
        exceptionText.text = "";
        exceptionBox.SetActive(true);
        Random_Cnt();
        yield return new WaitForSeconds(5.0f);
        exceptionBox.SetActive(false);
        fourth_BT.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    IEnumerator CarException()
    {
        exceptionText.text = "";
        exceptionBox.SetActive(true);
        Random_Cnt();
        yield return new WaitForSeconds(5.0f);
        exceptionBox.SetActive(false);
        fifth_BT.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    IEnumerator MedicalChartException()
    {
        exceptionText.text = "";
        exceptionBox.SetActive(true);
        Random_Cnt();
        yield return new WaitForSeconds(5.0f);
        exceptionBox.SetActive(false);
        sixth_BT.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    IEnumerator LiquorBottleException()
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