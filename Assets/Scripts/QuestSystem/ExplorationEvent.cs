using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplorationEvent : MonoBehaviour
{
    public delegate void ExplorationHandler(string currentLocation);
    public static event ExplorationHandler OnNewArea;

    public static void EnemyDied(string currentLocation)
    {
        if (OnNewArea != null)
        {
            OnNewArea(currentLocation);
        }
    }
}
