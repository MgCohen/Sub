﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class TargetableMapPoint : MonoBehaviour, IInteractableMapPoint
{

  private void Start()
  {
    GetComponent<SpriteRenderer>().color = Color.yellow;
  }
  public virtual void OnSelect()
  {
    if (InputManager.IsAiming)
    {
      OnTarget();
      return;
    }
  }

  public virtual void OnTarget()
  {
    //StationManager.Singleton.ActivateSelectedOn(this);
  }
}