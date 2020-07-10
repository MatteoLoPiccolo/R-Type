using UnityEngine;

public class PlayerController_FSM : MonoBehaviour, IMovable
{
    #region Variable
    PowerUp powerUpScriptableObj;

    // float screenBound
    float screenWidthInWorldUnits;

    private IMovable movable;

    // private refence RigidBody
    private Rigidbody rB;
    // public reference property to RigidBody
    public Rigidbody RB
    {
        get { return rB; }
    }

    public float Speed { get; private set; }
     
    #endregion

    #region Awake
    private void Awake()
    {
        // initialize RigidBody component
        rB = GetComponent<Rigidbody>();
        movable = GetComponent<IMovable>();
    }
    #endregion

    #region Start
    // Start is called before the first frame update
    void Start()
    {
        float halfPlayerWidth = transform.localScale.x / 2f;

        screenWidthInWorldUnits = Camera.main.aspect * Camera.main.orthographicSize - halfPlayerWidth;
    }
    #endregion

    #region Update
    // Update is called once per frame
    void Update()
    {
        ScreenBounds();

        transform.Translate(Move()); 
    }
    #endregion

    #region Method ScreenBounds, Move, Trigger, ForceMode
    private void ScreenBounds()
    {
        // screenBound for X Axis
        if (transform.position.x < -screenWidthInWorldUnits)
        {
            transform.position = transform.position = new Vector2(-screenWidthInWorldUnits, transform.position.y);
        }
        if (transform.position.x > screenWidthInWorldUnits)
        {
            transform.position = transform.position = new Vector2(screenWidthInWorldUnits, transform.position.y);
        }
    }

    public Vector3 Move()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");

        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical);        

        return movement.normalized * (/*movable.Speed*/ 10 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Missile_Drop")
        {
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            GameManager.Instance.KillPlayer();
        }
    }
    #endregion
}