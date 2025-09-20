using UnityEngine;
using UnityEngine.SceneManagement;

public class perehod2 : MonoBehaviour
{
    // Метод для перехода на следующую сцену по имени
    public void LoadSceneByName(string sceneName)
    {
        // Проверяем, что имя сцены не пустое
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName); // Загружаем сцену по имени
        }
        else
        {
            Debug.LogError("Имя сцены не может быть пустым!");
        }
    }

    // Метод для перехода на следующую сцену по ID
    public void LoadSceneByID(int sceneID)
    {
        // Проверяем, что ID сцены корректно
        if (sceneID >= 0)
        {
            SceneManager.LoadScene(sceneID); // Загружаем сцену по ID
        }
        else
        {
            Debug.LogError("ID сцены не может быть отрицательным!");
        }
    }

    // Метод для загрузки следующей сцены в Build Settings
    public void LoadNextScene()
    {
        // GetActiveScene() получает текущую активную сцену
        // buildIndex получает индекс сцены в списке Build Settings
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 2); // Переходим на следующую сцену
    }

    // Метод для перезагрузки текущей сцены
    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
