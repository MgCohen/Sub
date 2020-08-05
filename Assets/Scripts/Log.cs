using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Log")]
public class Log : ScriptableObject
{
    public GameObject source;
    public Vector2 logPosition;
    public int logTime;

    public int completionRate;

    public bool isCompleted
    {
        get
        {
            return (completionRate >= 10);
        }
    }

    [SerializeField]
    public List<Entry> entries = new List<Entry>();

    [ContextMenu("Get Text")]
    public string GetText()
    {
        string text = "";
        foreach(var e in entries)
        {
            text += e.source + ": " + e.text + "\n";
        }
        Debug.Log(text);
        return text;
    }


    public void Decode(int value)
    {
        completionRate += value;
    }
}

[System.Serializable]
public class Entry
{
    public string source;
    [TextArea] public string text;
}
