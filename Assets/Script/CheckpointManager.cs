using System.Linq;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    private Checkpoint[] checkpoints;

    // Start is called before the first frame update
    private void Start()
    {
        checkpoints = GetComponentsInChildren<Checkpoint>();
    }

    public Checkpoint GetLastCheckpointThatWasPassed()
    {
        return checkpoints.LastOrDefault(t => t.Passed);
    }
}
