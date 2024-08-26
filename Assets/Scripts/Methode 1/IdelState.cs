using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdelState : State
{
    private StateMechine stateMechine;
    public IdelState(StateMechine stateMechine)
    {
        this.stateMechine = stateMechine;
    }
    public override void EnterState()
    {
        Debug.Log("Enter the Idel State");
    }

    public override void ExitState()
    {
        Debug.Log("Exiting Idel State");   
    }

    public override void UpdateState()
    {
        Debug.Log("Updating Idel State");
        if (Input.GetKey(KeyCode.T))
        {
            stateMechine.SwitchState(new WalkingState(stateMechine));
            Debug.Log("Switcing the Walking state");
        }
    }
}
