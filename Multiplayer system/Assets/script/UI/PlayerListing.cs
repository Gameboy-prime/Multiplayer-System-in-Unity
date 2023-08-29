using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using TMPro;

public class PlayerListing : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;

    public  Player _player{get; private set;}

    public void PlayerInfo(Player player)
    {
        _player=player;
        text.text= player.NickName;
        
    }

}
