using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCanvas : MonoBehaviour
{
    [SerializeField]
    private CreateJoinRoomCanvas createJoinRoomCanvas;

    public CreateJoinRoomCanvas CreateJoinRoomCanvas{get{return createJoinRoomCanvas;}}

    [SerializeField]
    private CurrentRoomCanvas currentRoomCanvas;

    public CurrentRoomCanvas CurrentRoomCanvas{get{return currentRoomCanvas;}}

    private void Awake()
    {
        FirstInitialize();
    }

    private void FirstInitialize()
    {
        CreateJoinRoomCanvas.FirstInitialize(this);
        CurrentRoomCanvas.FirstInitialize(this);
    }


}
