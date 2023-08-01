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
        PhotonNetwork.GameVersion="1.0";
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("Connecting to server");
    
    }

    public override void OnConnectedToMaster()
    {
        //The reason they included this base by default is because this fuction is in a class that is inherinting from another class which is the base, But it wasn't inheriting, so it is pointless 
        base.OnConnectedToMaster();
        Debug.Log("Connected to server");
 
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        base.OnDisconnected(cause);
        Debug.Log("Reason for disconnection is: " + cause.ToString());
    }


}
