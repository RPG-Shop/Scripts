using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class interact : MonoBehaviour
{
    public GameObject panelPrefab;
    [SerializeField] private Camera camera;
    [SerializeField] private Transform player_Cam_Transform;
    [SerializeField] private string selectable_tag;
    //[SerializeField] private Text text1;


    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello!");
        //GameObject uiPanel = GameObject.Find("uiPanel");

        panelPrefab.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        //if (Input.GetMouseButtonDown(1))
        //{
        //    // 在這裡顯示UI
        //    panelPrefab.SetActive(true);
        //    //GameObject panelInstance = Instantiate(panelPrefab, canvas.transform);

        //}

        //if (Input.GetMouseButtonDown(1))
        //{
        //    //Ray ray = new Ray(transform.position, Vector3.forward);
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    //if (Physics.Raycast(ray, out hit) /*&& hit.transform.CompareTag("YourTag")*/)
        //    //{
        //    //    // 檢測到物體被右鍵點擊
        //    //    GameObject hitObject = hit.transform.gameObject;
        //    //    Debug.Log("Right-clicked on object: " + hitObject.name);
        //    //}
        //}

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("RC!");
            RaycastHit hit;
            Ray ray = new Ray(player_Cam_Transform.position, player_Cam_Transform.forward);
            if (Physics.Raycast(ray, out hit) && hit.transform.CompareTag(selectable_tag))
            {
                Debug.Log(hit.transform.name + " hit by the ray!");
                //text1.text = "Hello, I'm " + hit.transform.name;
                TMP_Text t_text = panelPrefab.GetComponent<TMP_Text>();
                Debug.Log(t_text);
                //t_text.text = hit.transform.name;
                panelPrefab.SetActive(true);
            }
            else
            {
                Debug.Log("TEST");
            }
        }
        

    }
}
