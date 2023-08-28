using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateJoinRoomCanvas : MonoBehaviour
{
    [SerializeField]
    private CreateRoomMenu createRoomMenu;
    private RoomCanvas roomCanvas;
    public void FirstInitialize(RoomCanvas canvas)
    {
        roomCanvas=canvas;
        createRoomMenu.FirstInitialize(canvas);

    }


}