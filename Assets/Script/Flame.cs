using UnityEngine;

public class Flame : MonoBehaviour
{
    #region Variable
    public PowerUp powerUp;
    #endregion

    #region Start
    // Start is called before the first frame update
    void Start()
    {
        // print data of power up
        powerUp.Print();
        // set damage to flame type
        FlameDamage();
    }
    #endregion

    #region Method Type of Damage
    private void FlameDamage()
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
