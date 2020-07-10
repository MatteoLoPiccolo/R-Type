using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    #region Variable
    public GameObject[] enemy;
    #endregion

    #region Start
    // Start is called before the first frame update
    void Start()
    {
        int randomIndex = Random.Range(0, enemy.Length);
        //Instantiate(enemy[randomIndex], new Vector3(2, 0, 0), enemy[randomIndex].transform.rotation);
        //print(enemy[randomIndex].gameObject.name);
    }
    #endregion

    #region Instantiate Enemy
    // TODO
    #endregion
}