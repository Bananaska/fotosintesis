using UnityEngine;
using UnityEngine.SceneManagement;

public class perehod2 : MonoBehaviour
{
    // ����� ��� �������� �� ��������� ����� �� �����
    public void LoadSceneByName(string sceneName)
    {
        // ���������, ��� ��� ����� �� ������
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName); // ��������� ����� �� �����
        }
        else
        {
            Debug.LogError("��� ����� �� ����� ���� ������!");
        }
    }

    // ����� ��� �������� �� ��������� ����� �� ID
    public void LoadSceneByID(int sceneID)
    {
        // ���������, ��� ID ����� ���������
        if (sceneID >= 0)
        {
            SceneManager.LoadScene(sceneID); // ��������� ����� �� ID
        }
        else
        {
            Debug.LogError("ID ����� �� ����� ���� �������������!");
        }
    }

    // ����� ��� �������� ��������� ����� � Build Settings
    public void LoadNextScene()
    {
        // GetActiveScene() �������� ������� �������� �����
        // buildIndex �������� ������ ����� � ������ Build Settings
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 2); // ��������� �� ��������� �����
    }

    // ����� ��� ������������ ������� �����
    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
