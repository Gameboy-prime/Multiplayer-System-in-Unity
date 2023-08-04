
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;
using Photon.Realtime;

public class CreateRoomMenu : MonoBehaviourPunCallbacks
{
    [SerializeField] private TextMeshProUGUI roomName;
    

    public void OnClickMakeRoom()
    {
        //Check to see if a connection has been made to Photon befpre making a room
        if(!PhotonNetwork.IsConnected)
        {
            RoomOptions options= new RoomOptions();
            options.MaxPlayers= MasterManger.GameSetting.PlayerNumber;
        

            PhotonNetwork.JoinOrCreateRoom(roomName.ToString(), options, TypedLobby.Default);
            Debug.Log("Making a room");

        }

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
