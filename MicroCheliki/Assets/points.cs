using TMPro;
using UnityEngine;

public class points : MonoBehaviour
{
    public TMP_Text pointsText;
   void ChangePoints(int newPoints)
    {
        pointsText.text = newPoints.ToString();
    }

    void Update()
    {
     ChangePoints(5);   
    }
}
