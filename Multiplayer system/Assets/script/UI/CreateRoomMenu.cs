
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
            return;
            

        }
        RoomOptions options= new RoomOptions();
        options.MaxPlayers= MasterManger.GameSetting.PlayerNumber;

        //Make sure the room name  is not empty when creating a room
        if(roomName.text==null)
        {
            Debug.Log("The room name cannot be empty");


        }
        else
        {
            PhotonNetwork.JoinOrCreateRoom(roomName.text, options, TypedLobby.Default);
            Debug.Log("Making a room");

        }
        

        
    }

    

    public override void OnCreatedRoom()
    {
        Debug.Log("Room Has Been Created");
        Debug.Log(PhotonNetwork.CountOfRooms);
        
        
        
        
    }
    


   public override void OnCreateRoomFailed(short returnCode, string message)
   {
        Debug.Log("The Room was not created because: "+ message );

   }
}
