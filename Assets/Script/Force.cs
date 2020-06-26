using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    #region Variable
    // reference to player, frontPosition and backPosition, frontFirePosition and backFirePosition
    public GameObject player;
    
    public GameObject frontPosition;    
    public GameObject backPosition;    
    public GameObject lauchPoint;
        
    [SerializeField]
    // speed variable
    private float rotationSpeed = 10f;
    #endregion

    #region Update
    // Update is called once per frame
    void Update()
    {
        Rotate();

        Launch();        
    }
    #endregion

    #region Method
    private void Rotate()
    {
        this.transform.Rotate((rotationSpeed * Time.deltaTime), 0f, 0f);
    }

    private void Launch()
    {
        if (transform.position == frontPosition.transform.position)
        {
            lauchPoint.transform.parent = this.transform.parent;

            if (Input.GetKeyDown(KeyCode.E))
            {
                float time = 1.5f;
                Vector3.Lerp(frontPosition.transform.position, lauchPoint.transform.position, time);
            }
        }
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
    }
    #endregion
}
