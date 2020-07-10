using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Variable
    public static GameManager Instance { get; private set; }
    public int Lives { get; private set; }

    public event Action<int> OnLivesChange;
    #endregion

    #region Awake
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            RestartGame();
        }
    }
    #endregion

    internal void KillPlayer()
    {
        Lives--;

        if(OnLivesChange != null)
            OnLivesChange(Lives);

        if (Lives <= 0)
            RestartGame();
        //else
            //SendPlayerToCheckpoint();
    }

    private void SendPlayerToCheckpoint()
    {
        var checkpointManager = FindObjectOfType<CheckpointManager>();

        var checkpoint = checkpointManager.GetLastCheckpointThatWasPassed();

        var player = FindObjectOfType<PlayerController_FSM>();

        player.transform.position = checkpoint.transform.position;
    }

    private void RestartGame()
    {
        Lives = 3;
        SceneManager.LoadScene(0);
    }
}
