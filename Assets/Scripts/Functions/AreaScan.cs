using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AreaScan 
{
    private List<Collider2D> _results = new List<Collider2D>();

    public IEnumerable<TargetableMapPoint> Scan(Vector2 position, int scanSize)
    {
        Physics2D.OverlapCircle(position, scanSize, new ContactFilter2D(), _results);
        return _results.Select(item => item.GetComponent<TargetableMapPoint>());
    }
}
