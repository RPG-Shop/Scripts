using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acttoplay : MonoBehaviour
{
    [SerializeField] private string cabinetTag = "cabinet";
    [SerializeField] private Transform playerCam_transform;
    private Transform _selection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_selection != null)
        {
            _selection = null;
        }
        Ray ray = new Ray(playerCam_transform.position, playerCam_transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag(cabinetTag))
            {
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    if (Input.GetMouseButton(1))
                    {
                        Debug.Log("happy");
                    }
                }
                _selection = selection;
            }

        }
    }
}
