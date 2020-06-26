﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame : MonoBehaviour
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

    #region Method Type of Damage
    private void FlameDamage()
    {
        powerUpScriptableObj.SetDamage(PowerUpScriptableObj.AttackType.Flame);
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