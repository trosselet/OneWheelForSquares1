using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dalle : MonoBehaviour
{
    // Start is called before the first frame update
    public bool EtatInput;
    public Animator animator;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            EtatInput = true;
            animator.SetBool("PlayerIn", EtatInput);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            EtatInput = false;
            animator.SetBool("PlayerIn", EtatInput);
            print("exit");
        }
    }
}
