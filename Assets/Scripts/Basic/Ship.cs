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

    public List<Station> Stations;
    public Engine engine;
    public Weapons weapons;
    public Sonar sonar;
    public Radio radio;
    public Repair repair;

    public Station SelectedStation;

    public void SelectStation()
    {
        //se ja tem selecionado, cancela
    }
    private void Start()
    {
        SetStations();
    }

    public void SetStations()
    {
        engine = GetComponent<Engine>();
        engine.Ship = this;
        weapons = GetComponent<Weapons>();
        weapons.Ship = this;
        sonar = GetComponent<Sonar>();
        sonar.Ship = this;
        radio = GetComponent<Radio>();
        radio.Ship = this;
        repair = GetComponent<Repair>();
        repair.Ship = this;
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
