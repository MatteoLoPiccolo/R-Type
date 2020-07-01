using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    #region Variable

    // reference to player, frontPosition and backPosition, frontFirePosition and backFirePosition and launchPoint
    public GameObject player, frontPosition, backPosition, frontFirePoint, backFirePoint, lauchPoint;

    [SerializeField]
    // speed variable
    private float rotationSpeed = 10f;
    #endregion

    #region Update
    // Update is called once per frame
    void Update()
    {
        // rotate force
        Rotate();
        // launch force in front position and go back
        //Launch();        
    }
    #endregion

    #region Method
    private void Rotate()
    {
        this.transform.Rotate((rotationSpeed * Time.deltaTime), 0f, 0f);
    }    

    #endregion

    #region Trigger
    private void OnTriggerEnter(Collider other)
    {       

        if (other.gameObject.tag == "Player")
        {
            if (transform.position.x >= player.transform.position.x)
            {
                this.transform.position = frontPosition.transform.position;
                this.transform.parent = frontPosition.transform;
                
                //player.GetComponent<Shoot>().enabled = false;
            }

            if (transform.position.x <= player.transform.position.x)
            {
                this.transform.position = backPosition.transform.position;
                this.transform.parent = backPosition.transform;                

                //player.GetComponent<Shoot>().enabled = false;
            }
        }

        if (other.gameObject.tag == "Enemy_Projectile")
        {
            Destroy(other.gameObject);
        }
    }
    #endregion
}
