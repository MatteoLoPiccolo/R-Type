using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameDrop : MonoBehaviour
{
    #region Variable
    [SerializeField]
    private GameObject flame;

    private MeshRenderer meshRenderer;
    #endregion

    #region Start 
    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.color = Color.yellow;
    }
    #endregion

    #region Trigger for collect PowerUp
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);

            Instantiate(flame, transform.position, Quaternion.identity);
        }
    }
    #endregion
}
