using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boinger : MonoBehaviour
{
    public float bounceForce = 21f;
    public float bounceTime = 0.05f;
    public string orientation = "up";
    private bool OnBoinger = false;

    private void OnTriggerEnter2D(Collider2D collision) // this is called if the player enter in the boinger and if is it true then the player will bump
    {

        if (collision.gameObject.tag == "Player")
        {
            OnBoinger = true;
            switch (orientation)
        {

            case "up":
                BounceUp(collision.gameObject);
                break;
            case "down":
                BounceDown(collision.gameObject);
                break;
            case "left":
                BounceLeft(collision.gameObject);
                break;
            case "right":
                BounceRight(collision.gameObject);
                break;
        }
            
        }
    }
    void Update()
    {
        
    }

    public void BounceUp(GameObject player) // this is called to bump the player up
    {
        if (OnBoinger == true)
        {   
            if (bounceTime > 0)
            {
                bounceTime -= Time.deltaTime;
                player.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounceForce, ForceMode2D.Impulse);
            }
            else
            {
                bounceTime = 0.5f;
                OnBoinger = false;
            }

        }
    }

    public void BounceRight(GameObject player) // this is called to bump the player right
    {
        if (OnBoinger == true)
        {
            if (bounceTime > 0)
            {
                bounceTime -= Time.deltaTime;
                player.GetComponent<Rigidbody2D>().velocity = new Vector2(27f , 0.1f) * bounceForce;
            }
            else
            {
                bounceTime = 0.5f;
                OnBoinger = false;
            }

        }
    }

    public void BounceDown(GameObject player) // this called to bump the player down
    {
        if (OnBoinger == true)
        {
            if (bounceTime > 0)
            {
                bounceTime -= Time.deltaTime;
                player.GetComponent<Rigidbody2D>().AddForce(Vector2.down * bounceForce, ForceMode2D.Impulse);
            }
            else
            {
                bounceTime = 0.5f;
                OnBoinger = false;
            }

        }
    }

    public void BounceLeft(GameObject player) // this is called to bump the player left
    {
        if (OnBoinger == true)
        {
            if (bounceTime > 0)
            {
                bounceTime -= Time.deltaTime;
                player.GetComponent<Rigidbody2D>().velocity = new Vector2(-27f , 0.1f) * bounceForce;
            }
            else
            {
                bounceTime = 0.5f;
                OnBoinger = false;
            }

        }
    }
}
