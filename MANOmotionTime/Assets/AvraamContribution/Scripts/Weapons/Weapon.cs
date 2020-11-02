using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arcade
{
    public abstract class Weapon : MonoBehaviour
    {
        //For future use so you can do elemental damage :D 
        public enum DamageType
        {
            Normal,
            Electric,
            Freeze,
            Fire,
            Virus
        }

        protected DamageType damageType;
        protected float damage;


        //Deal damage by collision trigger
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == Enemy.enemyTag)
            {
                other.GetComponent<Enemy>().TakeDamage(this.damage);
            }
        }

        public abstract void Fire(Vector3 firingPosition);
    }
}

