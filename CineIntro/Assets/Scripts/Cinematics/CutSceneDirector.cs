using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutSceneDirector : MonoBehaviour
{
    [SerializeField] private CinematicTrigger _cinematicTrigger;

    private PlayableDirector _playableDirector;

    private bool _isCutSceneTriggered;

    private void Awake()
    {
        _playableDirector = GetComponent<PlayableDirector>();

        _cinematicTrigger.cutSceneTriggeredEvent += OnCutSceneTriggered;
    }

    public void OnCutSceneTriggered()
    {
        if (!_isCutSceneTriggered)
        {
            _isCutSceneTriggered = true;
            _playableDirector.Play();
        }
    }
}
