using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using TMPro;

public class RoomListing : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;

    public  RoomInfo RoomInfo{get; private set;}

    public void SetRoomInfo(RoomInfo roominfo)
    {
        RoomInfo=roominfo;
        text.text= roominfo.MaxPlayers  + roominfo.Name;

    }

}
