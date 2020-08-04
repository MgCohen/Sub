using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonar : Station
{
  public int       scanSize = 16;
  List<Collider2D> results  = new List<Collider2D>();
  public override void Activate()
  {
    Scan();
  }

  [ContextMenu("scan")]
  public void Scan()
  {
    foreach (var col in results)
    {
      col.transform.GetComponent<SpriteRenderer>().color = Color.yellow;
    }
    
    Physics2D.OverlapCircle(transform.position, scanSize, new ContactFilter2D(), results);
    
    foreach (var col in results)
    {
      col.transform.GetComponent<SpriteRenderer>().color = Color.green;
    }
  }
}
