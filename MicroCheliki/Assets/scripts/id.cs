using UnityEngine;
using UnityEngine.SceneManagement;

public class id : MonoBehaviour
{
    
        void Start()
    {
        // �������� ������� �������� �����
        Scene currentScene = SceneManager.GetActiveScene();

        // �������� �� ������ � ���������� ������
        int buildIndex = currentScene.buildIndex;

        Debug.Log("������ ������� �����: " + buildIndex);
        Debug.Log("�������� ������� �����: " + currentScene.name);
    }
}

