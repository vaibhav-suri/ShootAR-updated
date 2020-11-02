using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//By using the namespace I can organize my scripts
namespace Arcade
{
    [RequireComponent(typeof(SpawnManager))]
    public class GameManager : MonoBehaviour
    {

        public enum SessionStatus
        {
            InTutorial,
            InGame,
            InOptions

        }
        //In the future this will be a seperate class
        SessionStatus currentStatus;
        SpawnManager spawnManager;


        public void StartGame()
        {

            spawnManager.InstantiateEnemiesOfCurrentLevel();
        }
    }
}

