using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentRoomCanvas : MonoBehaviour
{
    private RoomCanvas roomCanvas;
    public void FirstInitialize(RoomCanvas canvas)
    {
        roomCanvas=canvas;

    }

    public void Show()
    {
        gameObject.SetActive(true);

    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
