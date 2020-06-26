using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    #region Variable
    // reference to Force
    public GameObject force;
    // reference to projectile prefab
    public GameObject projectilePrefab;
    // reference to firePoint
    public GameObject firePoint;
    // reference to forceFirePoint
    public GameObject forceFirePoint;
    // reference to backFirePoint
    public GameObject forceBackFirePoint;
    // reference to launchPoint
    public GameObject launchPoint;

    
    #endregion

    #region Update
    private void Update()
    {
       Fire();
    }
    #endregion

    #region  Fire Bullet
    private void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = PoolManager.Instance.RequestBullet();
            bullet.transform.position = firePoint.transform.position;
            bullet.transform.rotation = firePoint.transform.rotation;
        }

        // TODO
        if (Input.GetKey(KeyCode.Space))
        {
            // Charge Shot
        }
    }
    #endregion
}