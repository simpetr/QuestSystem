using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[Serializable]
public class Quest
{

    public List<Goal> Goals;
    public int ID;
    public string QuestName;
    public bool IsUnlocked;
    public bool IsCompleted;
    public int Points;
    //public Item Reward;
    //public List<ScriptableGoal> Goals { get; set; }
    //public int ID { get; set; }
    //public string QuestName { get; set; }
    //public bool IsUnlocked { get; set; }
    //public bool IsCompleted { get; set; }
    //public int Points { get; set; }
    //public Item Reward { get; set; }

    public Quest()
    {
    }

    public Quest(List<Goal> goals, int iD, string questName, int points/*, Item reward*/)
    {
        Goals = goals;
        ID = iD;
        QuestName = questName;
        IsCompleted = false;
        IsUnlocked = false;
        Points = points;
        //Reward = reward;
    }

    public void UnlockQuest()
    {
        foreach(Goal g in Goals)
        {
            g.Init();
        }

        IsUnlocked = true;
    }
    
    public void CheckGoals()
    {
        IsCompleted = Goals.All(goal => goal.IsCompleted);
        if (IsCompleted)
        {
            Completed();
        }
    }

    public void Completed()
    {
        // Quest completed 
        //TODO GUI 
        //TODO Points+ reward
        Debug.Log("Quest COMPLETED");
    }


}
