#if UNITY_EDITOR

using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class QuestEditorTool : EditorWindow
{
    int questIdCounter = 0;
    string questName = "";
    bool isUnlocked;
    bool isCompleted;
    int points;
    int goalsNumber = 1;
    List<Goal> goalsList;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    [MenuItem("Tools/Create Quests")]
    public static void ShowWindow()
    {
        GetWindow(typeof(QuestEditorTool));
    }

    private void OnGUI()
    {
        GUILayout.Label("Create a json of quests", EditorStyles.boldLabel);
        GUILayout.Space(10f);
        GUILayout.Label(questIdCounter.ToString());
        questName = EditorGUILayout.TextField("Quest name", questName);
        isUnlocked = EditorGUILayout.Toggle("Unlocked", false);
        isCompleted = EditorGUILayout.Toggle("Completed", false);
        points = EditorGUILayout.IntField("Reward points", points);
        goalsNumber = EditorGUILayout.IntField("Goals component", goalsNumber);

        if (GUILayout.Button("Create next quest"))
        {
            //TODO add quest
            //TODO reset all fields
        }
        if (GUILayout.Button("Write Json"))
        {
            //TODO save json
        }

    }
}

#endif