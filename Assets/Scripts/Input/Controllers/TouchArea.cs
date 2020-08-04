using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchArea : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
  [SerializeField] private Camera targetCamera;
  public Vector2Int coordinates;
  private bool isHovering;

  private void OnValidate()
  {
    if (!targetCamera) targetCamera = Camera.main;
  }
  
  public void OnPointerEnter(PointerEventData eventData)
  {
    isHovering = true;
  }

  public void OnPointerExit(PointerEventData eventData)
  {
    isHovering = false;
  }

 

  private void Update()
  {
    if (!isHovering) return;
    var mousePos =  targetCamera.ScreenToWorldPoint(Input.mousePosition);
    coordinates = (mousePos - transform.position).toVector2Int();
  }

  
}
