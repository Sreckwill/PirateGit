using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkingState : PlayerBaseState
{
    public PlayerWalkingState(PlayerBaseStateMechine playerBaseStateMechine) : base(playerBaseStateMechine)
    {
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
            PlayerBaseStateMechine.SwitchState(new PlayerIdelState(PlayerBaseStateMechine));
            Debug.Log("Switcing the Idel state");
        }
    }
}
