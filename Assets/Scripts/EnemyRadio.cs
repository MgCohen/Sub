using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRadio : MonoBehaviour
{

    public Log OnHail;

    [SerializeField] public EncryptedLog OnLosingCity;
    [SerializeField] public EncryptedLog OnConqueringCity;
    [SerializeField] public EncryptedLog OnDefeat;
    [SerializeField] public EncryptedLog OnSpotting;

    public void BroadCast(EncryptedLog log)
    {
        //get range
        //find player
        if (!log.CheckTime()) return;
        if (!log.CheckRadio()) return;

        //log entry
        //notify
    }
}

[System.Serializable]
public class EncryptedLog
{
    public Log log;
    public int neededRadio;
    public int neededTime;

    //on losing
    //on conquer

    //on defeat
    //on spot

    public bool CheckTime()
    {
        return (Manager.currentTime >= neededTime);
    }

    public bool CheckRadio()
    {
        return true;
    }
}
