using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arcade
{
    [CreateAssetMenu(fileName = "Level", menuName = "Arcade Levels")]
    public class Level : ScriptableObject
    {
        public LevelInformation information;
    }

}
