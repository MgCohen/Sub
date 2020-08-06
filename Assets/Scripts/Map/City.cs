using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : TargetableMapPoint
{
    
    
    public override void Select()
    {
        base.Select();
        Debug.Log(name);
    }

    public override void Target()
    {
        base.Target();
    }
}
