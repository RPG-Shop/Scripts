using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCt : MonoBehaviour
{
    //視角參數https://blog.csdn.net/Z_hongli/article/details/109782483
    public Transform CameraRotation;
    private float Mouse_X;
    private float Mouse_Y;
    public float MouseSensitive = 150f;
    public float xRotation;

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //interactMask = LayerMask.GetMask("interactable");
    }

    // Update is called once per frame
    void Update()
    {
        //視角轉向
        Mouse_X = Input.GetAxis("Mouse X") * MouseSensitive * Time.deltaTime;
        Mouse_Y = Input.GetAxis("Mouse Y") * MouseSensitive * Time.deltaTime;
        xRotation -= Mouse_Y;
        xRotation = Mathf.Clamp(xRotation, -65f, 65f);
        CameraRotation.Rotate(Vector3.up * Mouse_X);
        this.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
    }
}
