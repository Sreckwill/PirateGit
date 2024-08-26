using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingState : State
{
    private StateMechine stateMechine;
    public WalkingState(StateMechine stateMechine)
    {
        this.stateMechine = stateMechine;
    }
    public override void EnterState()
    {
        Debug.Log("Walkking State");
    }

    public override void ExitState()
    {
        Debug.Log("Exiting then Walking State");
    }

    public override void UpdateState()
    {
        Debug.Log("Updating the Walking State");
        if (Input.GetKey(KeyCode.Y))
        {
            stateMechine.SwitchState(new IdelState(stateMechine));
            Debug.Log("Switcing the Idel state");
        }
    }
}
