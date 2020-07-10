using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDrop : MonoBehaviour
{
    #region Variable
    [SerializeField]
    private GameObject laser;

    private MeshRenderer meshRenderer;
    #endregion

    #region Start
    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.color = Color.blue;
    }
    #endregion

    #region Trigger for collect PowerUp
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            print(laser);
        }
    }
    #endregion
}
