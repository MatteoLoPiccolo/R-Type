using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void OnForceMode();
    public static event OnForceMode onForceMode;

    public void ForceMode()
    {
        if (onForceMode != null)
        {
            onForceMode();
        }
    }
}
