using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMotion : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject ball;
    public GameObject paddle;
    public Text player1TriesCounter;
    public Text player1Score;
    public Text gameOver;
    private float x;
    private float y;
    public int tries;
    private int plr1Score;
    private int reboundCount;
    private bool hitOrange = false;
    private bool hitRed = false;
    private bool hitTopWall = false;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        tries = 1;
        player1TriesCounter.text = tries.ToString();
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(2, 3);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Death")
        {
            RespawnBall();
        }
        if (collision.gameObject.tag == "Death" && tries == 4)
        {
            paddle.gameObject.transform.localScale = new Vector3(9.5f, 0.225f, 0);
            paddle.transform.position = new Vector3(0, -3.7f, 0);
            paddle.gameObject.GetComponent<PaddleMotion>().enabled = false;
            gameOver.gameObject.SetActive(true);
            Destroy(ball);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Yellow Brick")
        {
            plr1Score += 1;
            player1Score.text = plr1Score.ToString();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Green Brick")
        {
            plr1Score += 3;
            player1Score.text = plr1Score.ToString();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Orange Brick")
        {
            plr1Score += 5;
            player1Score.text = plr1Score.ToString();
            Destroy(collision.gameObject);
            hitOrange = true;
            if (hitOrange == true)
            {
                rb.velocity = new Vector2(5, 6);
            }
        }

        if (collision.gameObject.tag == "Red Brick")
        {
            plr1Score += 7;
            player1Score.text = plr1Score.ToString();
            Destroy(collision.gameObject);
            hitRed = true;
            if(hitRed == true)
            {
                rb.velocity = new Vector2(6, 7);
            }
        }

        if (collision.gameObject.tag == "Paddle")
        {
            reboundCount++;
            if(reboundCount == 4)
            {
                rb.velocity = new Vector2(3, 4);
            }
            if(reboundCount == 12)
            {
                rb.velocity = new Vector2(4, 5);
            }
        }

        if(collision.gameObject.tag == "Top Wall")
        {
            hitTopWall = true;
            if (hitTopWall == true)
            {
                paddle.gameObject.transform.localScale = new Vector3(0.3875f, 0.225f, 0);
            }
        }
    }

    private void RespawnBall()
    {
        reboundCount = 0;
        hitOrange = false;
        hitRed = false;
        x = Random.Range(-4.6f, 4.4f);
        y = Random.Range(-2.5f, 0);
        ball.transform.position = new Vector3(x, y, 0);
        rb.velocity = new Vector2(2, 3);
        tries++;
        player1TriesCounter.text = tries.ToString();
    }
}
