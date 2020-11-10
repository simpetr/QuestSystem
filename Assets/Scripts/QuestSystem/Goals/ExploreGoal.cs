//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ExploreGoal : Goal
//{
//    public string Location { get; }
//    public ExploreGoal(QuestType questType, string description, string location) : base(questType, description)
//    {
//        this.Location = location;
//    }

//    public override void Init()
//    {
//        base.Init();
//        ExplorationEvent.OnNewArea += ExploreArea;
//    }

//    public void ExploreArea(string currentLocation)
//    {
//        if (currentLocation == Location)
//        {
//            Evaluate();
//        }
//    }

//    public override void Evaluate()
//    {
//        base.Evaluate();
//        Debug.Log("YOu reached the right location");
//        Completed();


//    }


//}
