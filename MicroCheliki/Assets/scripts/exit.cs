using UnityEditor;
using UnityEngine;

public class exit : MonoBehaviour
{
    public void ExitGame() // �������� �������, ���������� �� ������
    {
        EditorApplication.ExitPlaymode();
    }
}