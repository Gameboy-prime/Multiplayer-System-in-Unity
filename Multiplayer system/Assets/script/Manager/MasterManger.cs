using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName ="Singleton/MasterManger")]
public class MasterManger : SingletonScriptableObject<MasterManger>
{
    
    [SerializeField] GameSetting gameSetting;

    public static GameSetting GameSetting
    {
        get {
            return instance.gameSetting;
            }
    }
}
