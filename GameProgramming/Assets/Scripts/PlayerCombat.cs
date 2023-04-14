using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    // Update is called once per frame
    public Animator animator;
    public Transform attackPoint;
     private Transform target;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    public int attackDamage = 50;
    void Update()
    {

    }

    void OnAttack ()
    {
        Attack();   
    }

    void Attack()
    {
        animator.SetTrigger("Attack");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
            target = enemy.transform;
            Vector3 dir = target.position - transform.position;
            if (dir.magnitude < 2)
            {
                enemy.GetComponent<enemyLife>().TakeDamage(attackDamage);
            }
        }
    }
    void OnDrawGizmosSelected()
        {
            if (attackPoint == null)
                return;

            Gizmos.DrawWireSphere(attackPoint.position, attackRange);
        }
}
