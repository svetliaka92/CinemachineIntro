using System;
using UnityEngine;

public class CinematicTrigger : MonoBehaviour
{
    public event Action cutSceneTriggeredEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            cutSceneTriggeredEvent?.Invoke();
        }
    }
}
