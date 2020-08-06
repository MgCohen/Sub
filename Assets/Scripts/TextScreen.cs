using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScreen : MonoBehaviour
{
    public Text logText;
    public Text logEntry;

    static TextScreen screen;

    private void Start()
    {
        screen = this;
        screen.Close();
    }

    public static void SetLog(Log log)
    {
        screen.gameObject.SetActive(true);
        screen.logEntry.text = log.logSource + "\n" + log.logTime + "-" + log.logPosition.x + "-" + log.logPosition.y;
        screen.logText.text = log.GetText();
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
