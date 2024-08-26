using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdelState : PlayerBaseState
{
    public PlayerIdelState(PlayerStateMechine stateMechine) : base(stateMechine)
    {
    }

    public override void EnterState()
    {
        
    }

    public override void UpdateState()
    {
        Debug.Log("Idelstate");
        if (Input.GetKeyDown(KeyCode.X))
        {
            stateMechine.SwitchState(new PlayerWalkState(stateMechine));
            Debug.Log("Switch to Walkingstate");
        }
    }

    public override void ExitState()
    {
       
    }

   

   
}
