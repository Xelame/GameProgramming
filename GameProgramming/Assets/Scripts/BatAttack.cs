using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatAttack : MonoBehaviour
{
     public int speed = 2;
    private Transform target;
    public Animator myAnimator;
    public int damageOnTouch = 20;

    private void OnCollisionEnter2D(Collision2D collision) // this is called for check if the bat touch the player and if it is true then the player will take damage 
    {
        if (collision.transform.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.transform.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(damageOnTouch);
        }
    }
    private void OnTriggerStay2D(Collider2D collision) // this is called for check if the player enter in bat detection area and if it is true then the bat will move to the player
    {
        if (collision.transform.CompareTag("Player"))
        {
            myAnimator.SetTrigger("enter");
            target = collision.transform;
            Vector3 dir = target.position - transform.position;
            transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        }
    }
}
