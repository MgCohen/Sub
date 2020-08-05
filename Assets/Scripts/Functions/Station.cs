using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Station : MonoBehaviour, IClock
{
    public StationManager Manager;
    public Ship Ship;
    public List<Crew> StationedCrew = new List<Crew>();

    public void Clock()
    {
        var count = StationedCrew.Count(member => member.ready);
        Act(count);
        Refresh();
    }


    public void Refresh()
    {
        foreach(var c in StationedCrew)
        {
            c.ready = true;
        }
    }

    public virtual void Act(int crewPower)
    {

    }

    public virtual void ActivateOn(TargetableMapPoint point)
    {
        Debug.Log(GetType() + " on " + point.name);
    }

    public virtual void Activate()
    {
        Spend();
    }

    public virtual void StartTarget()
    {
        if (Manager.SelectedStation == this) { ReleaseTarget(); return;}
        
        Manager.SetSelectedStation(this);
        Manager.Input.Aim();
    }

    public virtual void ReleaseTarget()
    {
        if (Manager.SelectedStation != this) return;
        
        Manager.DesselectStation();
        Manager.Input.ReleaseAim();
    }

    public bool Spend()
    {
        foreach (var member in StationedCrew.Where(member => member.ready))
        {
            member.ready = false;
            return true;
        }

        return false;
    }
}
