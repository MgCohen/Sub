using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputManager : InputManager
{
    [SerializeField] private Texture2D _defaultPointerTexture = default;
    [SerializeField] private Texture2D _aimPointerTexture = default;

    [ContextMenu("mouse aim")]
    public override void Aim()
    {
        base.Aim();
        Cursor.SetCursor(_aimPointerTexture, Vector2.one * _aimPointerTexture.width/2, CursorMode.Auto);
    }

    [ContextMenu("release mouse aim")]
    public override void ReleaseAim()
    {
        base.ReleaseAim();
        Cursor.SetCursor(_defaultPointerTexture, Vector2.zero, CursorMode.Auto);
    }

}
