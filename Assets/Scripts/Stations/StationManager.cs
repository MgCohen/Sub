using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StationManager : MonoBehaviour
{
    [SerializeField] private Ship ship;
    [SerializeField] private List<Station> _stations = default;
    [SerializeField] private Station _selectedStation = default;
    [SerializeField] private InputManager _inputManager = default;
    public Engine  Engine;
    public Weapons Weapons;
    public Sonar   Sonar;
    public Radio   Radio;
    public Repair  Repair;
    public InputManager Input => _inputManager;

    public Station SelectedStation => _selectedStation;


    public void SetStations(Ship ship)
    {
        this.ship = ship;
        Engine = GetComponentInChildren<Engine>();
        Engine.Ship = ship;
        Weapons = GetComponentInChildren<Weapons>();
        Weapons.Ship = ship;
        Sonar = GetComponentInChildren<Sonar>();
        Sonar.Ship = ship;
        Radio = GetComponentInChildren<Radio>();
        Radio.Ship = ship;
        Repair = GetComponentInChildren<Repair>();
        Repair.Ship = ship;
    }
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

    public void ActivateSelectedOn(TargetableMapPoint point)
    {
        _selectedStation.ActivateOn(point);
        _inputManager.ReleaseAim();
        _selectedStation = null;
    }

    public void ActivateSelected()
    {
        _selectedStation.Activate();
        _inputManager.ReleaseAim();
        _selectedStation = null;
    }
   
}
