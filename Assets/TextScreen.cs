using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TextScreen : MonoBehaviour
{
    public TextMeshPro text;
    public TextMeshPro text2;

    static TextScreen screen;

    private void Start()
    {
        screen = this;
    }

    public static void SetLog(Log log)
    {
        screen.gameObject.SetActive(true);
        screen.text.text = log.source.name;
        screen.text2.text = log.GetText();
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
