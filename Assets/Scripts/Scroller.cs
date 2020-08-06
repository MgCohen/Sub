using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Scroller : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    public Transform target;
    public RectTransform textBox;


    public void OnBeginDrag(PointerEventData eventData)
    {
        offset = Camera.main.ScreenToWorldPoint(eventData.position) - target.localPosition;
        offset.x = 0;
        offset.z = 0;
        textSize = textBox.sizeDelta.y;
    }

    Vector3 offset;
    float textSize;

    public void OnDrag(PointerEventData eventData)
    {
        var pos = Camera.main.ScreenToWorldPoint(eventData.position);
        pos.x = 0;
        pos.z = 0;
        pos -= offset;
        pos.y = Mathf.Clamp(pos.y, 0, textSize + 3);
        pos.y = Mathf.Ceil(pos.y);
        target.localPosition = pos;
        Debug.Log(1);
    }
}
