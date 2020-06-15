using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutSceneDirector : MonoBehaviour
{
    [SerializeField] protected CinematicTrigger _cinematicTrigger;

    protected PlayableDirector _playableDirector;

    protected bool _isCutSceneTriggered;

    private void Awake()
    {
        _playableDirector = GetComponent<PlayableDirector>();

        if (_cinematicTrigger)
            _cinematicTrigger.cutSceneTriggeredEvent += OnCutSceneTriggered;
    }

    public virtual void OnCutSceneTriggered()
    {
        if (_isCutSceneTriggered)
            return;

        //_isCutSceneTriggered = true;
        _playableDirector.Play();
    }
}
