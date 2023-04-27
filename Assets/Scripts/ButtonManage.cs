using System.Collections;
using System.Collections.Generic;
//using System.Linq; //OrderBy排序需要
using UnityEngine;
using UnityEngine.UI; //UI

//掛在Canvas底下
public class ButtonManage : MonoBehaviour
{
    public List<Button> buttons = new List<Button>(); //把傳送按鈕整理成list。要添加按鈕，到List增加Size的值，再把新按鈕物件拖進去
    public GameObject panel; //裝按鈕的視窗，那個按鈕背後半透明的板
    public Transform player; //玩家本人
    public CharacterController playerController; //玩家的控制器
    public int distance; //與傳送門的最遠感應距離
    public GameObject[] PlaceArray; //第一種按鈕與傳送點對應的方法，把傳送點裝成一個array
    //public GameObject allplaces; //第二種對應方法，把傳送點歸到同一個父物件底下

    // Start is called before the first frame update
    void Start()
    {
        AddClickEvents();
    }

    // Update is called once per frame
    void Update()
    {
        //PlaceArray = GameObject.FindGameObjectsWithTag("place").OrderBy(g => g.transform.GetSiblingIndex()).ToArray(); //傳送點tag需設成place，按Hierarchy的順序排列
        //判斷是否能開啟傳送視窗and隱藏自己所在地的傳送鈕
        bool dis = false;
        for(int i = 0; i < PlaceArray.Length; i++) 
        {
            if(Vector3.Distance(player.transform.position, PlaceArray[i].transform.position) <= distance)
            {
                dis = true;
                buttons[i].gameObject.SetActive(false);
                break;
            }
            else
            {
                buttons[i].gameObject.SetActive(true);
            }
        }
        //按E開啟傳送選項視窗
        if(Input.GetKeyDown(KeyCode.E) && dis)
        {
            panel.SetActive(true);
        }
        //按ESC關閉視窗
        if(Input.GetKeyDown(KeyCode.Escape) && panel.activeInHierarchy == true)
        {
            panel.SetActive(false);
        }
    }

    //判斷按了哪個鈕
    void AddClickEvents()
    {
        int x = 0;
        foreach(Button item in buttons)
        {
            int y = x;
            item.onClick.AddListener(() => SwitchPosBt(y));
            x++;
        }
    }

    void SwitchPosBt(int a)
    {
        //第一個按鈕對應第一個地點，以此類推，所以傳送點與按鈕順序需相同
        Debug.Log(buttons[a].name);
        Vector3 transPos = PlaceArray[a].transform.position + Vector3.up; //目的地座標 = 傳送點座標 + 比身高高的值（防卡模）
        //Vector3 transPos = allplaces.transform.GetChild(a).gameObject.transform.position + Vector3.up; //用父物件的方法

        playerController.enabled = false;
        player.transform.position = transPos; //傳送!!
        playerController.enabled = true;
        panel.SetActive(false); //關掉傳送視窗
    }
}
