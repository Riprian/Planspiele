﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionPutDownCup : ShareAction {

    private bool satDown = false;

    public override bool Finished()
    {
        return satDown;
    }

    public override void EnterAction()
    {
        Debug.Log("Enter ActionPutDownCup Action");

        _active = true;
        _instructionText.text = "Put down the Share Device or press D";

    }

    protected override void SetInstructionImages()
    {
        instructionImages = new Sprite[2];
        instructionImages[0] = Resources.Load<Sprite>("Lay1");
        instructionImages[1] = Resources.Load<Sprite>("Lay2");
    }

    public override void ExitAction()
    {
        SoundEffectManager.Instance.PlayPutCup();
    }

    // Update is called once per frame
    new void Update()
    {

        if (!ShareInputManager.ShareInput.IsPickedUp())
        {
            satDown = true;
        }


    }
}
