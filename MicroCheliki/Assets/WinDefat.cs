using UnityEngine;

public class WinDefat : MonoBehaviour
{
    public bool win = false;
    public bool defat = false;
    public bool touchBoss = false;
    int cloneScore = 1;

    public Animator animator;

    
    void Update()
    {
        if (cloneScore >= 100 && touchBoss == true)
        {
            win = true;
            animator.SetBool("win", true);
        }
        if (cloneScore <= 100 && touchBoss == true)
        {
            defat = true;
            animator.SetBool("def", true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            touchBoss = true;
        }
    }
}
