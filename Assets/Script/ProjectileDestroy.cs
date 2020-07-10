using UnityEngine;

public class ProjectileDestroy : MonoBehaviour
{
    #region OnEnable and Hide bullet
    private void OnEnable()
    {
        Invoke("Hide", 2f);
    }

    void Hide()
    {
        this.gameObject.SetActive(false);
    }
    #endregion
}
