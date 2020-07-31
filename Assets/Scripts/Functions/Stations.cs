using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stations : MonoBehaviour, IClock
{
    public Ship ship;
    public List<Crew> stationedCrew = new List<Crew>();

    public void Clock()
    {
        var count = 0;
        foreach(var c in stationedCrew)
        {
            if (c.ready) count++;
        }
        Act(count);
        Refresh();
    }


    public void Refresh()
    {
        foreach(var c in stationedCrew)
        {
            c.ready = true;
        }
    }

    public virtual void Act(int crewPower)
    {

    }

    public virtual void Activate()
    {
        Spend();
    }

    public virtual void Target()
    {
        //logica
        Activate();
    }

    public bool Spend()
    {
        foreach(var c in stationedCrew)
        {
            if (c.ready)
            {
                c.ready = false;
                return true;
            }
        }
        return false;
    }
}
