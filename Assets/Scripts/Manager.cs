using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour, IClock
{
    public static int currentTime;

    public void Clock()
    {
        currentTime++;
    }
}
