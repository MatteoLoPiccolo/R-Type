using UnityEngine;

public class Force : MonoBehaviour
{
    #region Variable

    // reference to player, frontPosition and backPosition, frontFirePosition and backFirePosition and launchPoint
    public GameObject player;

    [SerializeField]
    private Transform frontPosition;
    [SerializeField]
    private Transform backPosition;
    [SerializeField]
    private Transform frontFirePoint;
    [SerializeField]
    private Transform backFirePoint;
    [SerializeField]
    private Transform launchPoint;

    [SerializeField]
    // speed variable
    private float rotationSpeed = 10f;
    [SerializeField]
    private float speed;

    private float positionPercent;
    private int direction = 1;
    #endregion

    #region Update
    // Update is called once per frame
    void Update()
    {
        // rotate force
        Rotate();
        // launch force in front position and go back
        Launch();

       //float distance = Vector3.Distance(frontPosition.position, launchPoint.position);
       //float speedForDistance = speed / distance;
       //
       //positionPercent += Time.deltaTime * direction * speedForDistance;
       //
       //transform.position = Vector3.Lerp(frontPosition.position, launchPoint.position, positionPercent);
       //
       //if (positionPercent >= 1 && direction == 1)
       //    direction = -1;
       //else if (positionPercent <= 0 && direction == -1)
       //    direction = 1;


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
            }

            else if (transform.position.x <= player.transform.position.x)
            {
                this.transform.position = backPosition.transform.position;
                this.transform.parent = backPosition.transform;                
            }
        }

        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Enemy_Projectile")
        {
            Destroy(other.gameObject);
        }
    }
    #endregion

    private void Launch()
    {
        if (transform.position == frontPosition.position)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                positionPercent += Time.deltaTime * direction;

                transform.position = Vector3.Lerp(frontPosition.position, launchPoint.position, positionPercent);

                if (positionPercent >= 1 && direction == 1)
                    direction = -1;
                else if (positionPercent <= 0 && direction == -1)
                    direction = 1;
            }
        }
    }
}
