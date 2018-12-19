using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadQuests : MonoBehaviour
{

    List<Quest> quests = new List<Quest>();
    // Use this for initialization
    void Start()
    {
        TextAsset questdata = Resources.Load<TextAsset>("questdata"); // name in Unity

        string[] data = questdata.text.Split(new char[] { '\n' });
        for (int i = 1; i < data.Length - 1; i++)
        {
            string[] row = data[i].Split(new char[] { ',' });

            if (row[1] != "")

            {
                Quest q = new Quest();
                int.TryParse(row[0], out q.id);
                q.name = row[1];
                q.percentage = row[2];
                int.TryParse(row[3], out q.X);
                q.Y = row[4];
                quests.Add(q);
            }
        }

        foreach (Quest q in quests)
        {
            Debug.Log(q.name + ", " + q.percentage + "," + q.X + "," + q.Y);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
