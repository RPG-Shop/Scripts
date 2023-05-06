using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class showUI : MonoBehaviour
{
    [SerializeField] private string selectableTag = "selectable";
    [SerializeField] private Transform playerCam_transform;
    public GameObject show_UI;
    public TextMeshProUGUI informationUI;
    private Transform _selection;
    // Start is called before the first frame update
    void Start()
    {
        show_UI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            show_UI.SetActive(false);
        }
        if (Input.GetKey("e"))
        {
            if (_selection != null)
            {
                var selectionRenderer = _selection.GetComponent<Renderer>();
                show_UI.SetActive(true);
                _selection = null;
            }
            if (_selection == null)
            {
                show_UI.SetActive(false);
            }
            Ray ray = new Ray(playerCam_transform.position, playerCam_transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                var selection = hit.transform;
                if (selection.CompareTag(selectableTag))
                {
                    var selectionRenderer = selection.GetComponent<Renderer>();
                    if (selectionRenderer != null)
                    {
                        show_UI.SetActive(true);
                    }

                    _selection = selection;
                }

            }
        }
    }
}
