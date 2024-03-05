using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerLevel : MonoBehaviour
{
    public string NextLevel;
    int PlayerEnd = 0;
    // Start is called before the first frame update
    private void Update()
    {
        if (PlayerEnd == 4)
        {
            loadLevel();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            PlayerEnd++;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            PlayerEnd--;
        }
    }
    void loadLevel()
    {
        SceneManager.LoadScene(NextLevel);
    }
}
