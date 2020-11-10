using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


[Serializable]
public enum QuestType
{
    CollectGoal,
    KillGoal,
    ExploreGoal
}

[Serializable]
public class Goal
{

    public QuestType QuestType { get; set; }
    public Quest QuestRef { get; set; }
    public string Description { get; set; } 
    public bool IsCompleted { get; set; }

    public Goal(QuestType questType,Quest questRef, string description)
    {
        this.QuestRef = questRef;
        this.QuestType = questType;
        this.Description = description;
        this.IsCompleted = false;
        //QuestRef = null;
    }

    public virtual void Init()
    {
    }

    public virtual void Evaluate()
    {
    }

    public void SetQuestRef(Quest questRef)
    {
        QuestRef = questRef;
    }

    public void Completed()
    {
        //do when the goal is completed

        IsCompleted = true;
        QuestRef.CheckGoals();
        Debug.Log("Goal completed");
    }
}
