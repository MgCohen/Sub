using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    [SerializeField] private Vector2 _coordinates;
    [SerializeField] private Ship    _player = default;
    [SerializeField] private TargetableMapPoint _selectedPoint;


    public void SetTarget(TargetableMapPoint point)
    {
      _selectedPoint = point;
    }

    public void SetCoordinates(Vector2 coords)
    {
      _coordinates = coords;
      
    
    }

    private void Update()
    {
      if (!Input.GetKeyDown(KeyCode.Mouse0)) return;
      var activeStation = _player.StationManager.SelectedStation;


      if (activeStation != null)
      {
        if (_selectedPoint != null)
        {
          activeStation.ActivateOn(_selectedPoint);
        }
        else
        {
          activeStation.ActivateOn(_coordinates);
        }
      }
      else
      {
        _selectedPoint?.Select();
      }
      
      
    }
}
