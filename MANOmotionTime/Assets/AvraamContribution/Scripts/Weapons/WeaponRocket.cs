using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arcade
{
    public class WeaponRocket : Weapon
    {
        public override void Fire(Vector3 firingPosition)
        {
            //Add force forward?
            //And maybe die after some time?
        }

        private void OnEnable()
        {
            this.damage = 10;
            this.damageType = DamageType.Normal;
        }
    }
}

