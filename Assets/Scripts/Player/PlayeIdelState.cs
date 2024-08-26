using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeIdelState : States
{
    private StateMechine StateMechine;
    public PlayeIdelState(StateMechine stateMechine)
    {
       this.StateMechine = stateMechine;
    }

    public override void EnterState()
    {
        Debug.Log("Player Enter State");
    }

    public override void UpdateState()
    {
       if(Input.GetKeyDown(KeyCode.X))
       {
            Debug.Log("Player Update State");
            StateMechine.SwitchState(new PlayerWalkingState(StateMechine));
       }
    }

    public override void ExitState()
    {
        Debug.Log("Player Exit State");
    }
}
