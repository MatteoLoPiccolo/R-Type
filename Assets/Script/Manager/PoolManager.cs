using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    #region Variable
    private static PoolManager _instance;
    public  static PoolManager Instance 
    {
        get
        {
            if (_instance == null)
                Debug.LogError("The PoolManager is NULL.");

            return _instance;
        }
    }

    [SerializeField]
    private GameObject _bulletContainer;
    [SerializeField]
    private GameObject _bulletPrefab;
    [SerializeField]
    private List<GameObject> _bulletPool;
    #endregion

    #region Awake
    private void Awake()
    {
        _instance = this;
    }
    #endregion

    #region Start
    private void Start()
    {
        _bulletPool = GenerateBullets(10);
    }
    #endregion

    #region Method Generate Bullet e Request Bullet
    // create a pool of bullet
    List<GameObject> GenerateBullets(int amountOfBullets)
    {
        for (int i = 0; i < amountOfBullets; i++)
        {
            GameObject bullet = Instantiate(_bulletPrefab);
            bullet.transform.parent = _bulletContainer.transform;
            bullet.SetActive(false);
            _bulletPool.Add(bullet);
        }        

        return _bulletPool;
    }

    // ricicle bullet in don't have bullet active in hierarchy
    public GameObject RequestBullet()
    {
        foreach (var bullet in _bulletPool)
        {
            if (bullet.activeInHierarchy == false)
            {
                bullet.SetActive(true);
                return bullet;
            }
        }

        GameObject newBullet = Instantiate(_bulletPrefab);
        newBullet.transform.parent = _bulletContainer.transform;
        newBullet.SetActive(true);
        _bulletPool.Add(newBullet);

        return newBullet;
    }
    #endregion
}
