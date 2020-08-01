using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StationManager : MonoBehaviour
{
    [SerializeField] private List<Station> _stations = default;
    [SerializeField] private static Station _selectedStation = default;
    [SerializeField] private InputManager _inputManager = default;
    public InputManager Input => _inputManager;

    public static Station SelectedStation => _selectedStation;


    private void OnValidate()
    {
        _stations = GetComponentsInChildren<Station>().ToList();
        foreach (var station in _stations)
        {
            station.Manager = this;
        }
    }

    public void SetSelectedStation(Station station)
    {
        _selectedStation = station;
    }

    public void DesselectStation()
    {
        _selectedStation = null;
    }

    public void ActivateSelected()
    {
        _selectedStation.Activate();
        _inputManager.ReleaseAim();
        _selectedStation = null;
    }
   
}
