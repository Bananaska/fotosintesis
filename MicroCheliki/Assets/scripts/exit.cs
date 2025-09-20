using UnityEditor;
using UnityEngine;

public class exit : MonoBehaviour
{
    public void ExitGame() // Открытая функция, вызываемая из кнопки
    {
        EditorApplication.ExitPlaymode();
    }
}