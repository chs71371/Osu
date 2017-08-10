using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Page_Menu : MonoBehaviour
{

    public Button btn_logo;
    public Button btn_play;

    public Transform menuPos_1;
    public Transform menuPos_2;


    public void Start()
    {
        btn_logo.onClick.AddListener(OnClickMenu);
        btn_play.onClick.AddListener(PlayGame);
        menuPos_2.gameObject.SetActive(false);
        btn_logo.gameObject.transform.position = menuPos_1.transform.position;
    }

    public void OnClickMenu()
    {
        btn_logo.gameObject.transform.DOMove(menuPos_2.transform.position, 0.3f);
        menuPos_2.gameObject.SetActive(true);
    }

    public void PlayGame()
    {
        menuPos_2.gameObject.SetActive(false);
        btn_logo.gameObject.transform.DOMove(menuPos_1.transform.position, 0.3f);
    }

}
