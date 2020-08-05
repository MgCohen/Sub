using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchArea : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
  [SerializeField] private Camera _targetCamera;
  public Vector2 Coordinates;
  public TargetableMapPoint SelectedPoint;
  private bool _isHovering;
  private Vector2 MousePosition => _targetCamera.ScreenToWorldPoint(Input.mousePosition).RoundToInt() + Vector2.one * 0.5f;

  private void OnValidate()
  {
    if (!_targetCamera) _targetCamera = Camera.main;
  }
  
  public void OnPointerEnter(PointerEventData eventData)
  {
    _isHovering = true;
  }

  public void OnPointerExit(PointerEventData eventData)
  {
    SelectedPoint = FindTarget(MousePosition);
    if (SelectedPoint != null) return;
    _isHovering = false;
  }

 

  private void Update()
  {
    if (!_isHovering) return;

    Coordinates = MousePosition - transform.position.RoundToInt();
    // cursor.position = MousePosition;

    SelectedPoint = FindTarget(MousePosition);

  }

  private static TargetableMapPoint FindTarget(Vector2 mousePos)
  {
    var hitPoints = Physics2D.OverlapPointAll(mousePos);
    TargetableMapPoint target = null;
    
    foreach (var hit in hitPoints)
    {
      if (hit.TryGetComponent(out target)) break;
    }
    
    return target;
  }

  
}
