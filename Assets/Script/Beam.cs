using UnityEngine;

public class Beam : MonoBehaviour
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
        // set damage to missile type
        BeamDamage();
    }
    #endregion

    #region Method Type of Damage
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


