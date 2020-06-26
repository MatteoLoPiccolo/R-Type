using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingBitsDrop : MonoBehaviour
{
    #region Variable
    [SerializeField]
    private GameObject homingBits;

    private MeshRenderer meshRenderer;
    #endregion

    #region Start
    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.color = Color.cyan;
    }
    #endregion

    #region Trigger for collect PowerUp
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);

            Instantiate(homingBits, transform.position, Quaternion.identity);
        }
    }
    #endregion
}
