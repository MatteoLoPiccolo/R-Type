using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New PowerUp", menuName = "PowerUp", order = 1)]
public class PowerUp : ScriptableObject
{
    public enum AttackType { Beam, Laser, Flame, Missile, HomingBits }
    public AttackType attackType;

    public Image image;
    public string powerUpName;
    public int attackPower;
    public int level;
    public float speed;
    public float range;  

    public void Print()
    {
        Debug.Log("PowerUp : " + powerUpName + " Attack Type :" + attackType + " Attack Power: " + attackPower + " Level: " + level);
    }
}