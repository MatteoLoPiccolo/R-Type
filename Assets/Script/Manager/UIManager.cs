using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager _istance;

    public static UIManager Istance
    {
        get
        {
            if (_istance == null)
                print("UI Manager is NULL.");

            return _istance;
        }
    }   

    private void Awake()
    {
        _istance = this;
    }

    private static int highestScore;
    private int actualScore;

    public Text powerUp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
