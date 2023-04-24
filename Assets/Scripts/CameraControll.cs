using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    public Transform player_body;           //���a����

    //������v������
    public float mouse_sensitive = 1000f;           //�ƹ��F�ӫ�
    float x_rotation = 0f;          //��v���a�V����

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;           //��w�ƹ��b������
    }

    // Update is called once per frame
    void Update()
    {
        //����ƹ��b�����y�ФW�����ʶq
        float mouse_x = Input.GetAxis("Mouse X") * mouse_sensitive * Time.deltaTime;
        float mouse_y = Input.GetAxis("Mouse Y") * mouse_sensitive * Time.deltaTime;

        //��v���a�V����
        x_rotation -= mouse_y;
        x_rotation = Mathf.Clamp(x_rotation, -65f, 65f);            //������v���a�V����
        transform.localRotation = Quaternion.Euler(x_rotation, 0f, 0f);

        //��v����V����
        player_body.Rotate(Vector3.up * mouse_x);           //�HY�b������
    }
}
