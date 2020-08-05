using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diary : MonoBehaviour
{

    public List<Log> loggedEntries = new List<Log>();

    public void Decode(int value)
    {
        foreach(var l in loggedEntries)
        {
            if (!l.isCompleted) l.Decode(value);
        }
    }
}
