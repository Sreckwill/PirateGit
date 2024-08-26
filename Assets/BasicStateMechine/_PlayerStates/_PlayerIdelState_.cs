using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class _PlayerIdelState_ : _States
{
    private _StateMechine _stateMechine;

    public _PlayerIdelState_(_StateMechine stateMechine)
    {
        this._stateMechine = stateMechine;
    }
    public override void EnterState()
    {
        Debug.Log("Enter Idel state");
    }

    public override void UpdateState()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("update  state");
            _stateMechine.SwitchState(new _PlayerWalkingState_(_stateMechine));
            
            
        }
    }

    public override void ExitState()
    {
        Debug.Log("Exit idel state");
    }
}
