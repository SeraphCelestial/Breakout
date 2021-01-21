using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMotion : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject ball;
    public bool usAI;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float hMov = ray.origin.x;
        if (usAI)
        {
            transform.position = new Vector3(ball.transform.position.x, transform.position.y, 0);
        }

        rb.position = new Vector3(hMov, -3.7f, 0);
        if (transform.position.x < -4.4)
        {
            transform.position = new Vector3(-4.4f, -3.7f, 0);
        }
        if (transform.position.x > 4.2)
        {
            transform.position = new Vector3(4.2f, -3.7f, 0);
        }
    }
}
