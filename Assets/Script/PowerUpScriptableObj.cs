using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New PowerUp", menuName = "PowerUp", order = 1)]
public class PowerUpScriptableObj : ScriptableObject
{
    public enum AttackType { Beam, Laser, Flame, Missile, HomingBits }
    public AttackType attackType;


    public Image image;
    public string powerUpName;
    public int attackPower;
    public int level;
    public float speed;
    public float range; 
    
    public void SetDamage(AttackType _type)
    {
        switch (_type)
        {
            case AttackType.Beam:         
                break;
            case AttackType.Laser:
                break;
            case AttackType.Flame:
                break;
            case AttackType.Missile:
                break;
            case AttackType.HomingBits:
                break;
            default:
                break;
        }
    }

    public void Print()
    {
        Debug.Log("PowerUp : " + powerUpName + " Attack Type :" + attackType + " Attack Power: " + attackPower + " Level: " + level);
    }
}