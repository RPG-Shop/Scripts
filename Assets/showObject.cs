using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showObject : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject object4;
    public GameObject canva;

    void Start()
    {
        object1.SetActive(false);
        object2.SetActive(false);
        object3.SetActive(false);
        object4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public enum ObStatus
    {
        ob1,
        ob2,
        ob3,
        ob4
    }
    private ObStatus obstatus;
    private ObStatus Status
    {
        get
        {
            return obstatus;
        }
        set
        {
            obstatus = value;
            UpdateOb();
        }
    }
    public void UpdateOb()
    {
        object1.SetActive(obstatus == ObStatus.ob1);
        object2.SetActive(obstatus == ObStatus.ob2);
        object3.SetActive(obstatus == ObStatus.ob3);
        object4.SetActive(obstatus == ObStatus.ob4);
    }
    public void ob1()
    {
        Status = ObStatus.ob1;
    }
    public void ob2()
    {
        Status = ObStatus.ob2;
    }
    public void ob3()
    {
        Status = ObStatus.ob3;
    }
    public void ob4()
    {
        Status = ObStatus.ob4;
    }
}
