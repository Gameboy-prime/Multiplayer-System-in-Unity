
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;
using Photon.Realtime;

public class CreateRoomMenu : MonoBehaviourPunCallbacks
{
    [SerializeField] private TextMeshProUGUI roomName;
    [SerializeField] private int playerNumber=4;
    public int PlayerNumber{get {return playerNumber;}}

    public void OnClickMakeRoom()
    {
        RoomOptions options= new RoomOptions();
        options.MaxPlayers= PlayerNumber;
        

        PhotonNetwork.JoinOrCreateRoom(roomName.ToString(), options, TypedLobby.Default);
        Debug.Log("Making a room");


    }

    

    public override void OnCreatedRoom()
    {
        Debug.Log("Room Has Been Created");
    }
    


   public override void OnCreateRoomFailed(short returnCode, string message)
   {
        Debug.Log("The Room was not created because: "+ message );

   }
}
