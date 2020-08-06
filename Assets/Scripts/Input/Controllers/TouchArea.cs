using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchArea : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
  [SerializeField] private Map    _behaviourHandler;
  [SerializeField] private Camera _targetCamera;
  private bool _isHovering;
  private Vector2 MousePosition => _targetCamera.ScreenToWorldPoint(Input.mousePosition).RoundToInt() + Vector2.one * 0.5f;
  
  
  private void OnValidate()
  {
    if (!_targetCamera) _targetCamera = Camera.main;
    if (!_behaviourHandler) _behaviourHandler = GetComponent<Map>();
  }
  
  public void OnPointerEnter(PointerEventData eventData)
  {
    _isHovering = true;
  }

  public void OnPointerExit(PointerEventData eventData)
  {
    var point = FindTarget(MousePosition);
    _behaviourHandler?.SetTarget(point);
    
    if (point != null) return;
    _isHovering = false;
  }

 

  private void Update()
  {
    if (!_isHovering) return;
    
    var point = FindTarget(MousePosition);
    var coords = MousePosition - transform.position.RoundToInt();
    
    _behaviourHandler?.SetCoordinates(coords);
    _behaviourHandler?.SetTarget(point); 
    
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
