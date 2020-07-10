using UnityEngine;


public class Missile : MonoBehaviour
{
    #region Variable
    [SerializeField] private Transform target;    
    [SerializeField] private float rotationForce;

    private Rigidbody rb;
    public PowerUp powerUp;
    #endregion

    #region Start
    // Start is called before the first frame update
    void Start()
    {
        // reference to rb
        rb = GetComponent<Rigidbody>();
        // print data of power up
        powerUp.Print();        
    }
    #endregion

    #region Update
    private void Update()
    {
        HomingFire();    
    }
    #endregion

    #region Shoot and Trigger
    void HomingFire()
    {
        
        // if target is not null
        if (target != null)
        {
            // direction = enemy position - my position
            Vector3 direction = target.position - rb.position;
            // normalized direction
            direction.Normalize();
            // the rotation amount is equal to cross product between missile diretion and diffrence between enemy position and missile position 
            Vector3 rotationAmount = Vector3.Cross(transform.right, direction);
            // 
            rb.angularVelocity = rotationAmount * rotationForce;
            // the facing direction where shoot
            rb.velocity = transform.right * powerUp.speed;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
    #endregion
}
