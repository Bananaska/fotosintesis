using UnityEngine;

public class leave : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))  // ���� ������ ������� Esc (Escape)
        {
            Application.Quit();    // ������� ����������
        }
    }
}
