using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public bool Passed { get; private set; }

    private void OnTriggerEnter(Collider other)
    {
        var player = GetComponent<PlayerController_FSM>();

        if (player != null)
        {
            Passed = true;
        }
    }
}
