using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpaceShip : Enemy
{
    private void OnEnable()
    {
        this.health = 100;
    }
    public override void Die()
    {
        this.gameObject.SetActive(false);
    }

    public override void TakeDamage(float damageAmmount)
    {
        health -= damageAmmount;
        if (health <= 0)
        {
            Die();
        }
    }
}
