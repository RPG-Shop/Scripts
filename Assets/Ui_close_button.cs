using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ui_close_button : MonoBehaviour
{
    public GameObject panelPrefab;
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(close_UI);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void close_UI()
    {
        panelPrefab.SetActive(false);
    }
}
