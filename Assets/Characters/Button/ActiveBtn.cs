using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Animator animator;
    public GameObject WallAssociate;
    // Start is called before the first frame update
    void Start()
    { 
        
        animator = GetComponent<Animator>();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            print("Lalala");
            animator.SetTrigger("PlayerOn");
            Destroy(WallAssociate);
        }
    }
}
