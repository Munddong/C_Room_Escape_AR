using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MakerText : MonoBehaviour
{
    public GameObject makerBox;
    public GameObject Restart;
    public GameObject Exit;

    public Text makerText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LastDialogue());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator LastDialogue()
    {
        makerText.text = "";
        makerBox.SetActive(true);

        makerText.DOText("Created by\n\nhomerunny01\nvalhallada\nO_0Nice", 16.0f);
        yield return new WaitForSeconds(16.0f);
        Restart.SetActive(true);
        Exit.SetActive(true);
    }
}
