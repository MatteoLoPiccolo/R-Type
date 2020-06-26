using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTypeShoot : MonoBehaviour
{
    #region Variable
    // set speed of projectile
    public float speed = 30;
       
    #endregion

    #region Update
    // Update is called once per frame
    void Update()
    {
        // set projectile's direction and velocity
        transform.Translate(Vector3.right * (speed * Time.deltaTime));
    }
    #endregion
}
