using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : TargetableMapPoint
{
    
    
    public override void OnSelect()
    {
        base.OnSelect();
        Debug.Log(name);
    }

    public override void OnTarget()
    {
        base.OnTarget();
    }
}
