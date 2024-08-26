using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _PlayerWalkingState_ :_States
{
    private _StateMechine _stateMechine;
    public _PlayerWalkingState_(_StateMechine stateMechine)
    {
        this._stateMechine = stateMechine;
    }
    public override void EnterState()
    {
        Debug.Log("enter state");
    }

    public override void UpdateState()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
           Debug.Log("update state");
           _stateMechine.SwitchState(new _PlayerIdelState_(_stateMechine));
        }
    }

    public override void ExitState()
    {
        Debug.Log("exit state");
    }
}
