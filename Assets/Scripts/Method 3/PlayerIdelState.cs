using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdelState : PlayerBaseState
{
    public PlayerIdelState(PlayerBaseStateMechine playerBaseStateMechine) : base(playerBaseStateMechine)
    {
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
            PlayerBaseStateMechine.SwitchState(new PlayerWalkingState(PlayerBaseStateMechine));
            Debug.Log("Switcing the Walking state");
        }
    }
}
