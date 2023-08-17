using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using TMPro;

public class RoomListing : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;

    //public  RoomInfo Info{get; private set;}

    public void SetRoomInfo(RoomInfo info)
    {
        //Info=info;
        text.text= info.MaxPlayers  + info.Name;

    }

}
