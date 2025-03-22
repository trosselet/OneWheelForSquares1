using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyByDash : MonoBehaviour
{
    public bool enemy;
    public string NextLevel;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(collision.gameObject.GetComponent<CreateMovement>().canmove == false)
            {
                Destroy(this.gameObject);
            }
            else
            {
                if(enemy)
                {
                    Destroy(collision.gameObject);
                    StartCoroutine(Attendre());

                }
            }
        }
        
    }
    public IEnumerator Attendre()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(NextLevel);
    }
}

