using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    #region Variable 
    public PowerUpScriptableObj powerUpScriptableObj;
    #endregion

    #region Start
    // Start is called before the first frame update
    void Start()
    {
        powerUpScriptableObj.Print();        
    }
    #endregion

    #region Method BeamDamage
    public void BeamDamage()
    {
        
    }
    #endregion

    #region Trigger for collect PowerUp
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
    #endregion
}


