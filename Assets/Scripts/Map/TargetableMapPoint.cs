using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class TargetableMapPoint : MonoBehaviour, IInteractableMapPoint
{

  private void Start()
  {
    GetComponent<SpriteRenderer>().color = Color.yellow;
  }
  public virtual void Select()
  {
    if (InputManager.IsAiming)
    {
      Target();
      return;
    }
  }

  public virtual void Target()
  {
    //StationManager.Singleton.ActivateSelectedOn(this);
  }
}
