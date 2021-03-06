﻿using UnityEngine;

public class EnemyDropSystem : MonoBehaviour
{
    #region Variable
    public GameObject[] powerUp;
    #endregion Trigger for collect PowerUp

    #region
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Projectile" || other.gameObject.tag == "Force")
        {
            Destroy(this.gameObject);
            
            int randomIndex = Random.Range(0, powerUp.Length);
            Instantiate(powerUp[randomIndex], transform.position, Quaternion.identity);
        }
    }
    #endregion
}
