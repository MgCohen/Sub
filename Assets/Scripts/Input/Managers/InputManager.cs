using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InputManager : MonoBehaviour
{
    
    [SerializeField] private static bool _isAiming;
    public static bool IsAiming => _isAiming;
    
    public virtual void Aim()
    {
        _isAiming = true;
    }

    public virtual void ReleaseAim()
    {
        _isAiming = false;
    }
}
