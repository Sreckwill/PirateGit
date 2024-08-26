using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkState : PlayerBaseState
{
    public PlayerWalkState(PlayerStateMechine stateMechine) : base(stateMechine)
    {
    }

    public override void EnterState()
    {
        
    }

    public override void UpdateState()
    {
        Debug.Log("Walkingstate");
        if (Input.GetKeyDown(KeyCode.Z))
        {
            stateMechine.SwitchState(new PlayerIdelState(stateMechine));
            Debug.Log("Switch to Idel");
        }
    }

    public override void ExitState()
    {
        
    }

    
}
