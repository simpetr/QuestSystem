using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;

public class QuestsLoader : MonoBehaviour
{
    //TODO probably add singleton
    [SerializeField]
    private string jsonQuestsFileName;
    private List<Quest> questDes;
    private Dictionary<string, int> questDic;
    JsonSerializerSettings settings = new JsonSerializerSettings
    {
        TypeNameHandling = TypeNameHandling.All,
        PreserveReferencesHandling = PreserveReferencesHandling.Objects
    };
    // Start is called before the first frame update
    void Start()
    {
        questDes = new List<Quest>();
        string jsonPath = Application.persistentDataPath + "/" + jsonQuestsFileName;
        //Read the json
        using (StreamReader reader = new StreamReader(jsonPath))
        {
            string json = reader.ReadToEnd();
            //convert the json into a list
            questDes = JsonConvert.DeserializeObject<List<Quest>>(json, settings);
            questDic = new Dictionary<string, int>();
            //load a dictionary with quest name and relative index in the list 
            //might be removed in next version
            int index = 0;
            foreach (Quest q in questDes)
            {
                questDic.Add(q.QuestName, index);
                index++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnDestroy()
    {
        
    }

    private void UnloadQuests()
    {
        //TODO check saving json - overwrite
        string jsonPath = Application.persistentDataPath + "/" + jsonQuestsFileName;
        using (StreamWriter stream = new StreamWriter(jsonPath))
        {
            string json = JsonConvert.SerializeObject(questDes, settings);
            stream.Write(json);
        }
    }
}
