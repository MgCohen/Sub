using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Log")]
public class Log : ScriptableObject
{
    public string logSource;
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

    public string GetText()
    {
        string text = "";
        foreach(var e in entries)
        {
            text += e.source + ": " + e.text;
            if (e != entries[entries.Count - 1]) text += "\n \n";
        }
        return text;
    }

    [ContextMenu("Call")]
    public void Call()
    {
        TextScreen.SetLog(this);
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
