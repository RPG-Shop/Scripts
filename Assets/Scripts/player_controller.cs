using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    public Transform player_body;           //玩家角色

    //角色攝影機控制
    public float mouse_sensitive = 1000f;           //滑鼠靈敏度
    float x_rotation = 0f;          //攝影機縱向角度

    //角色移動
    public float speed = 10f;           //移動速度
    public CharacterController player_movement;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;           //鎖定滑鼠在視窗內
    }

    // Update is called once per frame
    void Update()
    {
        CharacterRotation();
        CharcterMovement();
    }

    void CharacterRotation()
    {
        //獲取滑鼠在平面座標上的移動量
        float mouse_x = Input.GetAxis("Mouse X") * mouse_sensitive * Time.deltaTime;
        float mouse_y = Input.GetAxis("Mouse Y") * mouse_sensitive * Time.deltaTime;

        //攝影機縱向移動
        x_rotation -= mouse_y;
        x_rotation = Mathf.Clamp(x_rotation, -65f, 65f);            //限制攝影機縱向角度
        transform.localRotation = Quaternion.Euler(x_rotation, 0f, 0f);

        //攝影機橫向移動
        player_body.Rotate(Vector3.up * mouse_x);           //以Y軸做旋轉
    }


    void CharcterMovement()
    {
        float move_x = Input.GetAxis("Horizontal");
        float move_z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * move_x + transform.forward * move_z;

        player_movement.Move(move * speed * Time.deltaTime);
    }
}
