using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestsManager : MonoBehaviour
{

    public static int ConvertNameToIndex(string questName)
    {
        return 0;
    }

    public static string ConvertIndexToName(int id)
    {
        return "name";
    }

    public static bool ActiveQuest(int id)
    {
        return false;
    }

    public static bool ActiveQuest(string questName)
    {
        return false;
    }

    public static bool IsActive(int id)
    {
        return false;
    }

    public static bool IsActive(string questName)
    {
        return false;
    }



}
