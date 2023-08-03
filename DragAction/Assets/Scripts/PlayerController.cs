using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool isGround = false;
    Rigidbody2D rb2D;
    Transform tr;
    public Vector3 plTr;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        speed = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = plTr;
        Debug.Log(rb2D.velocity);
        PlayerControll();
    }

    void PlayerControll()
    {
        if(Input.GetKey(KeyCode.D))
        {
            rb2D.velocity = new Vector2(3 * speed, rb2D.velocity.y);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            rb2D.velocity = new Vector2(-3 * speed, rb2D.velocity.y);
        }


        if(Input.GetKey(KeyCode.Space))
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, 3);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
