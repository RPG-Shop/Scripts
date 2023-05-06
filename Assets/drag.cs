using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class drag : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panelPrefab;

    void Start()
    {
       
    }

    private void OnMouseDrag()
    {
        Debug.Log("Dragging...");
    }

}
