using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileDrop : MonoBehaviour
{
    #region Variable
    [SerializeField]
    private GameObject missile;

    private MeshRenderer meshRenderer;
    #endregion

    #region Start
    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.color = Color.black;
    }
    #endregion
    #region Trigger for collect PowerUp
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);

            Instantiate(missile, transform.position, Quaternion.identity);
        }
    }
    #endregion
}
