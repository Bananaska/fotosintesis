using UnityEngine;

public class leave : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))  // если нажата клавиша Esc (Escape)
        {
            Application.Quit();    // закрыть приложение
        }
    }
}
