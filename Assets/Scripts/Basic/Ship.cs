using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{

    public int Size;
    public int Atk;
    public int Def;
    public int Speed;
    public int Hp;
    public int Fuel;
    public int MaxHp;
    public int MaxFuel;
    public int structureDamage;

    public Vector2 Coordinates;
    public int noise;
    public int gold;
    [SerializeField] private StationManager _stationManager;


    private void OnValidate()
    {
        _stationManager = GetComponentInChildren<StationManager>();
        _stationManager?.SetStations(this);
    }
    private void Start()
    {
       
    }


    public void TakeDamage(int amount)
    {
        Hp -= amount;
        structureDamage++;
        //set bar size
        if (Hp <= 0)
        {
            //Destroy
        }
    }

    public void Repair(int amount)
    {
        Hp += amount;
        Hp = Mathf.Clamp(Hp, 0, MaxHp - structureDamage);
    }

    public void FullRepair()
    {
        Hp = MaxHp;
        structureDamage = 0;
    }



}
