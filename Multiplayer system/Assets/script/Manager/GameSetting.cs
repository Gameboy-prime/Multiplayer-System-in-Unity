using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Manager/GameSetting")]
public class GameSetting : ScriptableObject
{
    [SerializeField] private string nickName="Craig";
    public string NickName{
        get
        {
            int num= Random.Range(0,999);
            return nickName + num.ToString();
        }
    }

    [SerializeField] private string gameVersion="0.0.0";

    public string GameVersion{
        get{
            
            return gameVersion ;
            }
    }

    [SerializeField] private string welcomeMessage= "Wa Gbayi";

    public string WelcomeMessage
    {
        get{
            return welcomeMessage ;
        }

    }

    
    
}
