using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class selectionmanager : MonoBehaviour
{
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private Camera camera;
    [SerializeField] private string selectableTag = "selectable";
    [SerializeField] private Transform playerCam_transform;
    //public string no = "none";
    public string cube = "cube"; 
    public TextMeshProUGUI informationUI;
    private Transform _selection;
    private bool openUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //informationUI.text = no;
        if(_selection != null){
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            //informationUI.text = no;
            _selection = null;
        }
        //var ray = camera.ScreenPointToRay(Input.mousePosition); 
        Ray ray = new Ray(playerCam_transform.position, playerCam_transform.forward);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit)){
            var selection = hit.transform;
            if(selection.CompareTag(selectableTag)){
                var selectionRenderer = selection.GetComponent<Renderer>();
                Debug.Log(hit);
                string objName = hit.transform.name;

                if(selectionRenderer != null){
                    selectionRenderer.material = highlightMaterial;
                    informationUI.text = objName;
                }
                _selection = selection;
            }
            
        }
    }
}
