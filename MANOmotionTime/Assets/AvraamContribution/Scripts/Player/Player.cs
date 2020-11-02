using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Arcade
{
    [RequireComponent(typeof(PlayerInteraction))]
    public class Player : MonoBehaviour
    {//In the future this will be a seperate class ->Inventory.
        [SerializeField]
        List<GameObject> inventoryOfWeapons;


        Weapon currentWeapon;

        private void Awake()
        {
            PlayerInteraction.OnFiringDetected += HandleFiringDetected;
        }

        private void HandleFiringDetected(Vector3 firingPosition)
        {
            currentWeapon.Fire(firingPosition);
        }






    }
}

