using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    public Transform player_body;           //���a����

    //������v������
    public float mouse_sensitive = 1000f;           //�ƹ��F�ӫ�
    float x_rotation = 0f;          //��v���a�V����

    //���Ⲿ��
    public float speed = 10f;           //���ʳt��
    public CharacterController player_movement;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;           //��w�ƹ��b������
    }

    // Update is called once per frame
    void Update()
    {
        CharacterRotation();
        CharcterMovement();
    }

    void CharacterRotation()
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


    void CharcterMovement()
    {
        float move_x = Input.GetAxis("Horizontal");
        float move_z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * move_x + transform.forward * move_z;

        player_movement.Move(move * speed * Time.deltaTime);
    }
}
