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

    public List<Stations> Stations;
    public Engine engine;
    public Weapons weapons;
    public Sonar sonar;
    public Radio radio;
    public Repair repair;

    private void Start()
    {
        SetStations();
    }

    public void SetStations()
    {
        engine = GetComponent<Engine>();
        engine.ship = this;
        weapons = GetComponent<Weapons>();
        weapons.ship = this;
        sonar = GetComponent<Sonar>();
        sonar.ship = this;
        radio = GetComponent<Radio>();
        radio.ship = this;
        repair = GetComponent<Repair>();
        repair.ship = this;
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


    public void Clock()
    {
        //move
    }

}
