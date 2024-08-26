using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBaseState : States
{
    public PlayerStateMechine stateMechine;
    public PlayerBaseState(PlayerStateMechine stateMechine)
    {
        this.stateMechine = stateMechine;
    }
}
