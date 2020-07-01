using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    #region Variable
    // reference to force, force front position, force back position, projectile, fireéPoint, force fire point, force back fire point, launchPoint, laser position up, mid and down
    public GameObject force, forceFrontPosition, forceBackPosition, projectilePrefab, firePoint, forceFirePoint, forceBackFirePoint, launchPoint, laserUp, laserMid, laserDown;
        
    #endregion    

    #region Update
    private void Update()
    {
       Fire();

       Launch();
    }
    #endregion

    #region  Fire Bullet
    private void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Space) && force.transform.position != forceFrontPosition.transform.position)
        {
            GameObject bullet = PoolManager.Instance.RequestBullet();
            bullet.transform.position = firePoint.transform.position;
            bullet.transform.rotation = firePoint.transform.rotation;
        }

        if (Input.GetKeyDown(KeyCode.Space) && force.transform.position == forceFrontPosition.transform.position)
        {
            GameObject bullet = PoolManager.Instance.RequestBullet();
            bullet.transform.position = forceFirePoint.transform.position;
            bullet.transform.rotation = forceFirePoint.transform.rotation;
        }

        if (Input.GetKeyDown(KeyCode.Space) && force.transform.position == forceBackPosition.transform.position)
        {
            GameObject bullet = PoolManager.Instance.RequestBullet();
            bullet.transform.position = forceBackFirePoint.transform.position;
            bullet.transform.rotation = forceBackFirePoint.transform.rotation;
        }

        // TODO
        if (Input.GetKey(KeyCode.Space))
        {
            // Charge Shot
        }
    }

    private void Launch()
    {
        if (force.transform.position == forceFrontPosition.transform.position)
        {
            float distance = 30; 
            
            if (Input.GetKeyDown(KeyCode.E))
            {                
                //force.transform.position = Vector3.Lerp(forceFrontPosition.transform.position, launchPoint.transform.position, wait);
                force.transform.position = launchPoint.transform.position;
            }            
        }
    }
    #endregion
}