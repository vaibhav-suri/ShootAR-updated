using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arcade
{
    public class SpawnManager : MonoBehaviour
    {


        [SerializeField]
        List<Level> allLevels = new List<Level>();

        Level currentLevel;


        private void OnEnable()
        {
            //You need a smarter way to start from somewhere;
            currentLevel = allLevels[0];
        }


        public void InstantiateEnemiesOfCurrentLevel()
        {

            for (int i = 0; i < currentLevel.information.enemyNumbers; i++)
            {
                GameObject newEnemyObject = currentLevel.information.enemyPrefab;

                //SpaceShip0 Spaceship1
                newEnemyObject.name = currentLevel.information.enemyPrefab.name + i.ToString();
            }

        }


        private void ClearLevel()
        {
            //There are no enemies remaining in this level.
        }

    }
}

