using UnityEngine;

public class Shoot : MonoBehaviour
{
    #region Variable
    [SerializeField]
    private GameObject projectilePrefab;
    [SerializeField]
    private Transform force;
    [SerializeField]
    private Transform forceFrontPosition;
    [SerializeField]
    private Transform forceBackPosition;
    [SerializeField]
    private Transform firePoint;
    [SerializeField]
    private Transform forceFirePoint;
    [SerializeField]
    private Transform forceBackFirePoint;
    [SerializeField]
    private Transform launchPoint;
    [SerializeField]
    private Transform laserUp;
    [SerializeField]
    private Transform laserMid;
    [SerializeField]
    private Transform laserDown;

    private PowerUp powerUp;

    private float positionPercent;
    private int direction = 1;
    #endregion

    #region Start
    private void Start()
    {

    }
    #endregion

    #region Update
    private void Update()
    {
        SetBulletPositionAndRotation();

        SetChargeShootPosition();

        SetLaserPositionAndRotation();
    }
    #endregion

    #region  Fire Bullet
    private void SetBulletPositionAndRotation()
    {
        if (Input.GetKeyDown(KeyCode.Space) && force.position != forceFrontPosition.transform.position)
        {
            GameObject bullet = PoolManager.Instance.RequestBullet();
            bullet.transform.position = firePoint.position;
            bullet.transform.rotation = firePoint.rotation;
        }

        if (Input.GetKeyDown(KeyCode.Space) && force.position == forceFrontPosition.position)
        {
            GameObject bullet = PoolManager.Instance.RequestBullet();
            bullet.transform.position = forceFirePoint.position;
            bullet.transform.rotation = forceFirePoint.rotation;
        }

        if (Input.GetKeyDown(KeyCode.Space) && force.position == forceBackPosition.position)
        {
            GameObject bullet = PoolManager.Instance.RequestBullet();
            bullet.transform.position = forceBackFirePoint.position;
            bullet.transform.rotation = forceBackFirePoint.rotation;
        }
    }

    private void SetLaserPositionAndRotation()
    {
        
    }

    void SetChargeShootPosition()
    {
        // TODO
        if (Input.GetKey(KeyCode.Space))
        {
            // Charge Shot
        }
    }
    #endregion
}

