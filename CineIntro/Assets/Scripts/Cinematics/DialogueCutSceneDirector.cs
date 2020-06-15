using UnityEngine;

public class DialogueCutSceneDirector : CutSceneDirector
{
    [SerializeField] private NPC npc1;
    [SerializeField] private NPC npc2;
    [SerializeField] private GameObject keyInfoPanel;

    private bool _checkForInput = false;
    private bool _isInputLast = false;

    private NPC talkingNPC;

    private void Update()
    {
        if (!_checkForInput)
            return;

        if (Input.GetKeyDown(KeyCode.N))
        {
            _checkForInput = false;
            _playableDirector.Resume();

            keyInfoPanel.SetActive(false);

            SwitchTalkingNPC();
        }
    }

    public override void OnCutSceneTriggered()
    {
        _playableDirector.Play();
        talkingNPC = npc2;
        SwitchTalkingNPC();
    }

    public void NextNPC()
    {
        if (!_isInputLast)
            SwitchTalkingNPC();
        else
        {
            npc1.ShowText(false);
            npc2.ShowText(false);
        }
    }

    public void OnWaitForInputStarted(bool isInputLast = false)
    {
        _isInputLast = isInputLast;
        _checkForInput = true;
        _playableDirector.Pause();
        keyInfoPanel.SetActive(true);
    }

    private void SwitchTalkingNPC()
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
