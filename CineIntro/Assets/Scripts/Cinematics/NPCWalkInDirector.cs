using UnityEngine;

public class NPCWalkInDirector : CutSceneDirector
{
    [SerializeField] private NPC[] npcs;
    [SerializeField] private Transform[] npcStartLocations;
    [SerializeField] private Transform[] npcEndLocations;
    [SerializeField] private float animDelay = 3f;
    [SerializeField] private float animTime = 3f;

    private void Start()
    {
        for (int i = 0; i < npcs.Length; i++)
            npcs[i].transform.position = npcStartLocations[i].position;
    }

    public override void OnCutSceneTriggered()
    {
        base.OnCutSceneTriggered();

        for (int i = 0; i < npcs.Length; i++)
            LeanTween.move(npcs[i].gameObject, npcEndLocations[i].position, animTime)
                     .setEaseInOutExpo()
                     .setDelay(animDelay);
    }
}
