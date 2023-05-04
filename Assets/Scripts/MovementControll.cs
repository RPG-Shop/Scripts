using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControll : MonoBehaviour
{
    //���Ⲿ��
    public float speed = 10f;           //���ʳt��
    public CharacterController player_movement;
    public float gravity = 0.98f;
    Vector3 vertical_velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float move_x = Input.GetAxis("Horizontal");
        float move_z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * move_x + transform.forward * move_z;

        player_movement.Move(move * speed * Time.deltaTime);

        vertical_velocity.y -= gravity * Time.deltaTime;

        player_movement.Move(vertical_velocity * Time.deltaTime);
    }
}
