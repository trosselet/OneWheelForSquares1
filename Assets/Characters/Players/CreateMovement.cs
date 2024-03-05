using System.Collections;
using UnityEngine;

// Yellow Dash
// Blue Transformation
// Red Double Jump
// Green Stop in sky

public class CreateMovement : MonoBehaviour
{
    public Transform Transform;
    public Rigidbody2D body;
    public Animator animator;

    public float speed;
    public float powerJump;
    public bool GetJump;
    public string cmdJump;
    public string cmdRight;
    public string cmdLeft;
    public string cmdDown;
    public string color;
    public bool getFreeze = false;
    public bool canmove = true;
    private int direction = 1;
    public bool little = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canmove)
        {


            // si j'appui sur 'd' alors velocity x = 1
            // si j'appui sur 'q' alors velovity x = -1

            Vector2 currentVelocity = new Vector2(0, body.velocity.y);

            if (Input.GetKey(cmdRight))
            {
                currentVelocity += new Vector2(1 * speed, 0);
                direction = 1;
            }
            if (Input.GetKey(cmdLeft))
            {
                currentVelocity += new Vector2(-1 * speed, 0);
                direction = -1;
            }
            if (Input.GetKeyDown(cmdJump) && GetJump == true)
            {
                body.AddForce(new Vector2(0, 1 * powerJump));
                GetJump = false;
            }
            if (Input.GetKeyDown(cmdDown) && color == "green")
            {
                if (getFreeze)
                {
                    GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
                    getFreeze = false;
                }
                else
                {
                    GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
                    getFreeze = true;
                }

            }
            if (Input.GetKeyDown(cmdDown) && color == "blue")
            {
                if (little == true)
                {
                    little = false;
                }
                else
                {
                    little = true;
                }
                animator.SetBool("TransformScale", little);
            }
            body.velocity = currentVelocity;
        }

        if (Input.GetKeyDown(cmdDown) && (canmove) && color == "yellow")
        {

            StartCoroutine(CanMove());
            body.velocity = new Vector2(0, 0);

            if (direction == 1)
            {
                body.velocity += new Vector2(3 * speed, 5);
            }

            if (direction == -1)
            {
                body.velocity -= new Vector2(3 * speed, -5);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            GetJump = true;
        }
        if (collision.gameObject.tag == "Player")
        {
            GetJump = true;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" && color == "red")
        {
            GetJump = true;
        }
        if (collision.gameObject.tag == "Player" && color == "red")
        {
            GetJump = true;
        }
    }

    public IEnumerator CanMove()
    {
        canmove = false;
        yield return new WaitForSeconds(1);
        canmove = true;
    }
}
