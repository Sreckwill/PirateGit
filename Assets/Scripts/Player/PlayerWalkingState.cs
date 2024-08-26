using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkingState : States
{
    private StateMechine StateMechine;
    public PlayerWalkingState(StateMechine stateMechine)
    {
        this.StateMechine = stateMechine;
    }
    public override void EnterState()
    {
        Debug.Log("Enter walking State");
    }

    public override void UpdateState()
    {
        Debug.Log("Updating the Walking state");
        if(Input.GetKeyDown(KeyCode.Z))
        {
            StateMechine.SwitchState(new PlayeIdelState(StateMechine));    
        }
    }

    public override void ExitState()
    {
        Debug.Log("Exiting the Walking state");
    }

    
}
