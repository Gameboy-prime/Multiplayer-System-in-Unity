using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;

public class RoomListMenu : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private Transform content;

    [SerializeField]
    private RoomListing roomlisting;

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        foreach (RoomInfo info in roomList)
        {
             RoomListing listing= Instantiate(roomlisting,content);
            if(listing != null)
            {
                listing.SetRoomInfo(info);
            }

        }
        
    } 




}
