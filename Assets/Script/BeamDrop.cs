using UnityEngine;

public class BeamDrop : MonoBehaviour
{
    #region Variable
    [SerializeField]
    private GameObject beam;


    private MeshRenderer meshRenderer;
    #endregion

    #region Start
    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.color = Color.red;
    }
    #endregion

    #region Trigger for collect PowerUp
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {            
            Destroy(this.gameObject);
        }
    }
    #endregion
}
