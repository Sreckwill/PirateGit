using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBaseState : PlayerStates
{
   public PlayerBaseStateMechine PlayerBaseStateMechine;
    public PlayerBaseState(PlayerBaseStateMechine playerBaseStateMechine)
    {
       this.PlayerBaseStateMechine = playerBaseStateMechine;
    }
}
