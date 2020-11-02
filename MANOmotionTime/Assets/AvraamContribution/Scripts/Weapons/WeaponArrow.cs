using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Arcade
{
    public class WeaponArrow : Weapon
    {
        public override void Fire(Vector3 firingPosition)
        {
            //add force forward?
        }

        private void OnEnable()
        {
            this.damage = 10;
            this.damageType = DamageType.Normal;
        }
    }
}

