using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class TestConnect : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        //Setting the values of the game setting
        PhotonNetwork.GameVersion=MasterManger.GameSetting.GameVersion;
        PhotonNetwork.NickName= MasterManger.GameSetting.NickName;
        
        
        //THen we connect using the settings set
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("Connecting to server");
    
    }

    public override void OnConnectedToMaster()
    {
        //The reason they included this base by default is because this fuction is in a class that is inherinting from another class which is the base, But it wasn't inheriting, so it is pointless 
        base.OnConnectedToMaster();
        Debug.Log("Connected to server");
        string name=PhotonNetwork.LocalPlayer.NickName;
        Debug.Log(MasterManger.GameSetting.WelcomeMessage + " " + name.ToUpper());
 
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        base.OnDisconnected(cause);
        Debug.Log("Reason for disconnection is: " + cause.ToString());
    }


}
