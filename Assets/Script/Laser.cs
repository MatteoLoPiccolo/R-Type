using UnityEngine;

public class Laser : MonoBehaviour
{
    #region Variable
    // reference to powerup
    public PowerUp powerUp;

    // set speed of projectile
    public float speed = 30;
    #endregion

    #region Start
    // Start is called before the first frame update
    void Start()
    {
        // print data of power up
        powerUp.Print();
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

    #region Shoot Laser
    private void ShootLaser()
    {
        
    }
    #endregion

}
