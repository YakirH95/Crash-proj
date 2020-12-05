using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonScript : MonoBehaviour
{
    static SingletonScript _instance;

    public static SingletonScript instance
    {
        get
        {
            if(_instance == null)
            {
                GameObject manager = new GameObject("[SingletinScript]");
                _instance = manager.AddComponent<SingletonScript>();
                DontDestroyOnLoad(manager);
            }
            return _instance;
        }


    }
}
