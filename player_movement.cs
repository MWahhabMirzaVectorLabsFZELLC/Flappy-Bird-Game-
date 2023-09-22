using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player_movement : MonoBehaviour
{
    Rigidbody2D myrigidbody;

    public Text coinText;
    int NumCoin;

    public float speed;
    public float jumpSpeed;


    // Start is called before the first frame update
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        myrigidbody.velocity = new Vector2(speed, myrigidbody.velocity.y);

        if (Input.anyKeyDown)
        {
            myrigidbody.velocity = new Vector2(myrigidbody.velocity.x, jumpSpeed);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "obstacles")

        {
            UIManager.Instance.GameOver(); 
           
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.tag== "coin")
        {
            NumCoin += 1;
             coinText.text=NumCoin.ToString();
        Destroy(collision.gameObject);  
        }
    }
    
}


