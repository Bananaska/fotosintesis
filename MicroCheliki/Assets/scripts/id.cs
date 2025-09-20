using UnityEngine;
using UnityEngine.SceneManagement;

public class id : MonoBehaviour
{
    
        void Start()
    {
        // Получаем текущую активную сцену
        Scene currentScene = SceneManager.GetActiveScene();

        // Получаем ее индекс в параметрах сборки
        int buildIndex = currentScene.buildIndex;

        Debug.Log("Индекс текущей сцены: " + buildIndex);
        Debug.Log("Название текущей сцены: " + currentScene.name);
    }
}

