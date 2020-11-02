using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public static string enemyTag = "Enemy";
    protected float health;
    public abstract void TakeDamage(float damageAmmount);
    public abstract void Die();

}
