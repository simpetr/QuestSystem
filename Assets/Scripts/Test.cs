using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Quest simpleQuest = new Quest();
        simpleQuest.ID = 0;
        simpleQuest.QuestName = "Orc doesn't like magic";
        simpleQuest.IsCompleted = false;
        simpleQuest.IsUnlocked = false;
        simpleQuest.Points = 1000;

        KillGoal goal = new KillGoal(QuestType.KillGoal,simpleQuest,  "Kill the Orc", 10, 0, 3);
        ItemGoal goal2 = new ItemGoal(QuestType.CollectGoal, simpleQuest,  "Find the Potion", 4, 0, new Item(1, "pozione", "pozione potente"));
        List<Goal> list = new List<Goal>();
        list.Add(goal);
        list.Add(goal2);
        simpleQuest.Goals = list;

        Quest goldenRoad = new Quest();
        goldenRoad.ID = 1;
        goldenRoad.QuestName = "A thousand of golds";
        goldenRoad.IsCompleted = false;
        goldenRoad.IsUnlocked = false;
        goldenRoad.Points = 2340;
        ItemGoal goldGoal = new ItemGoal(QuestType.CollectGoal, goldenRoad, "Find 1000 gold", 1000, 0, new Item(2, "Coin", "A gold coin"));
        List<Goal> list2 = new List<Goal>();
        list2.Add(goldGoal);
        goldenRoad.Goals = list2;




        List<Quest> questList = new List<Quest>();
        questList.Add(simpleQuest);
        questList.Add(goldenRoad);
        string path = Application.persistentDataPath + "/data.json";
        JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All, PreserveReferencesHandling = PreserveReferencesHandling.Objects};
        //using (StreamWriter stream = new StreamWriter(path))
        //{
        //    string json = JsonConvert.SerializeObject(questList, settings);
        //    stream.Write(json);
        //}

        //Load
        //using (StreamReader reader = new StreamReader(path))
        //{
        //    string json = reader.ReadToEnd();
        //    Quest readQuest = JsonConvert.DeserializeObject<Quest>(json, settings);
        //    Debug.Log(readQuest.ID);
        //    Debug.Log(readQuest.Points);

        //    KillGoal i = readQuest.Goals[0] as KillGoal;
        //    Debug.Log(i.QuestType);
        //    Debug.Log(i.Description);
        //    Debug.Log(i.QuestRef);

        //    Debug.Log(i.RequiredAmount);

        //    Goal x = readQuest.Goals[0];
        //    Debug.Log(x.QuestType);
        //    Debug.Log(x.Description);
        //    Debug.Log(x.IsCompleted);

        //    CollectGoal c = readQuest.Goals[1] as CollectGoal;
        //    Debug.Log(c.QuestType);
        //    Debug.Log(c.Description);
        //    Debug.Log(c.QuestRef);

        //    Debug.Log(c.Item.Name);

        //}
        List<Quest> questDes = new List<Quest>();
        using (StreamReader reader = new StreamReader(path))
        {
            string json = reader.ReadToEnd();
            questDes = JsonConvert.DeserializeObject<List<Quest>>(json, settings);
            foreach (Quest q in questDes)
            {
                Debug.Log(q.QuestName);

                foreach(Goal g in q.Goals)
                {
                    Debug.Log(g.Description);
                }
                q.UnlockQuest();
            }

            
            PickUpEvent.PickupItem(new Item(2, "Coin", "A gold coin"));
            PickUpEvent.PickupItem(new Item(2, "Coin", "A gold coin"));
            PickUpEvent.PickupItem(new Item(4, "Diamond", "WOW a diamond"));
            PickUpEvent.PickupItem(new Item(4, "Diamond", "WOW a diamond"));
            EnemyKillEvent.EnemyDied(3);
        }
    }





}
