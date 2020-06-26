using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Variable
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
                print("Game Manager is NULL.");

            return _instance;
        }        
    }
    #endregion

    #region Awake
    private void Awake()
    {   
        _instance = this;
    }
    #endregion       
}
