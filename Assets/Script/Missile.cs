using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Missile : MonoBehaviour
{
    #region Variable
    [SerializeField] private Transform target;    
    [SerializeField] private float rotationForce;

    private Rigidbody rb;
    public PowerUpScriptableObj powerUpScriptableObj;
    #endregion

    #region Start
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        powerUpScriptableObj.Print();
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
            rb.velocity = transform.right * powerUpScriptableObj.speed;            
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
