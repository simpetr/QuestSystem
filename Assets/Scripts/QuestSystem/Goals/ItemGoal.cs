using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class ItemGoal : Goal
{
    public int RequiredAmount;
    public int CurrentAmount;
    public Item Item { get; set; }

    public ItemGoal(QuestType questType, Quest questRef, string description, int requiredAmount, int currentAmount, Item item) : base(questType, questRef, description)
    {
        this.RequiredAmount = requiredAmount;
        this.CurrentAmount = currentAmount;
        this.Item = item;
    }

    public override void Init()
    {
        base.Init();
        Debug.Log("Here");
        PickUpEvent.OnPickup += ItemPickedUp;
    }

    public void ItemPickedUp(Item item)
    {
        if (item.ID == this.Item.ID)
        {
            CurrentAmount++;
            Debug.Log(item.ID + "found");
            Evaluate();
        }
    }

    public override void Evaluate()
    {
        base.Evaluate();
        Debug.Log("Checked " + CurrentAmount);
        if (CurrentAmount >= RequiredAmount)
        {
            Completed();
        }
    }

}
