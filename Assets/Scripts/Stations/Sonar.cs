using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonar : Station
{
  public int       scanSize = 16;
  public override void Activate()
  {
    Scan();
  }

  [ContextMenu("scan")]
  public void Scan()
  {
    
  }
}
