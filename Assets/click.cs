using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine;

public class click : MonoBehaviour
{
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button close;
    public GameObject show_UI;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    // Start is called before the first frame update
    void Start()
    {
        obj1.SetActive(false);
        obj2.SetActive(false);
        obj3.SetActive(false);
        obj4.SetActive(false);
        btn1.onClick.AddListener(() => {
            OnBtnClick();
            obj1.SetActive(true);
        });
        btn2.onClick.AddListener(() => {
            OnBtnClick();
            obj2.SetActive(true);
        });
        btn3.onClick.AddListener(() => {
            OnBtnClick();
            obj3.SetActive(true);
        });
        btn4.onClick.AddListener(() => {
            OnBtnClick();
            obj4.SetActive(true);
        });
        close.onClick.AddListener(() => {
            OnBtnClick();
            obj1.SetActive(false);
            obj2.SetActive(false);
            obj3.SetActive(false);
            obj4.SetActive(false);
        });
    }
    void OnBtnClick()
    {
        show_UI.SetActive(false);
        //Debug.Log("0000");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
