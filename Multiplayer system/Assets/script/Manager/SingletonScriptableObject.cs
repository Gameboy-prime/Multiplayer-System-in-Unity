using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SingletonScriptableObject<T> : ScriptableObject where T: ScriptableObject
{
    public static T _instance=null;
    public static T instance{
        get
        {
            if(_instance== null)
            {
                T[] result= FindObjectsOfType<T>();
                if(result.Length==0)
                {
                    Debug.LogError("No Game Object of the scriptable was created ");
                }

                else if(result.Length>1)
                {
                    Debug.LogError("The Game Object has been instantiated many times");

                }

                else{
                    _instance= result[0];
                }
                

            }
            return _instance;
        }
    }
}
