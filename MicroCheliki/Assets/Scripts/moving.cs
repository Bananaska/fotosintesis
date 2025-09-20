using System;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.InputSystem;

public class SimplePlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private InputSystem_Actions action;
    private void Start()
    {
        action = new InputSystem_Actions();
        action.Enable();
    }

    private Vector2 moveInput = Vector2.zero;

    // ���� ����� ����� ������ Unity Input System ��� ��������� �������� Move
    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    private void Update()
    {

        Vector2 input = action.Player.Move.ReadValue<Vector2>();
        Vector3 move = new Vector3(input.x, 0, input.y);
        Vector3 forward = new Vector3 (0, 0, speed);
        // ����������� Vector2 (x,y) � Vector3 (x,0,z)
       
        // Vector 2 ( -1 , 0) 

        // ������� ������ � ��������� ������������
        transform.Translate(move * speed * Time.deltaTime, Space.World);
        transform.Translate(forward * speed * Time.deltaTime, Space.World);
    }
}