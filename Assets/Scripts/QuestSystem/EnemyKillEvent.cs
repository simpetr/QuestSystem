using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKillEvent : MonoBehaviour
{
    public delegate void EnemyDeathHandler(int enemyId);
    public static event EnemyDeathHandler OnEnemyDeath;

    public static void EnemyDied(int enemyId)
    {
        if (OnEnemyDeath != null)
        {
            OnEnemyDeath(enemyId);
        }
    }

}
