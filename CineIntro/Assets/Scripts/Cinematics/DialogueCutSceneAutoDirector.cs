using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueCutSceneAutoDirector : CutSceneDirector
{
    [SerializeField] private NPC npc1;
    [SerializeField] private NPC npc2;

    private NPC talkingNPC;

    public override void OnCutSceneTriggered()
    {
        _playableDirector.Play();
        talkingNPC = npc1;
        SwitchTalkingNPC();
    }

    public void SwitchTalkingNPC()
    {
        bool isNextTalkingNPC1 = talkingNPC != npc1;

        talkingNPC = (isNextTalkingNPC1) ? npc1 : npc2;

        if (isNextTalkingNPC1)
        {
            npc1.ShowText();
            npc2.ShowText(false);
        }
        else
        {
            npc1.ShowText(false);
            npc2.ShowText();
        }
    }
}
