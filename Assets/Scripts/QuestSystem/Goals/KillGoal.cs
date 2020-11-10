using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KillGoal : Goal
{
    public int RequiredAmount;
    public int CurrentAmount;
    public int EnemyId { get; set; }
    

    public KillGoal(QuestType questType, Quest questRef, string description, int requiredAmount, int currentAmount, int enemyId) : base(questType, questRef, description)
    {
        this.RequiredAmount = requiredAmount;
        this.CurrentAmount = currentAmount;
        this.EnemyId = enemyId;
    }

    public override void Init()
    {
        base.Init();
        EnemyKillEvent.OnEnemyDeath += EnemyDied;
    }

    public void EnemyDied(int enemyId)
    {
        if(this.EnemyId == enemyId)
        {
            Debug.Log("Enemy with ID" + enemyId + "has been killed");
            Debug.Log("Quest ID: " + QuestRef.QuestName);
            CurrentAmount++;
            Evaluate();
        }
    }
    public override void Evaluate()
    {
        base.Evaluate();
        if (CurrentAmount >= RequiredAmount)
        {
            Completed();
        }
    }

    
}
