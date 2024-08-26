using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBaseStateMechine : PlayerStateMechine
{
    // Start is called before the first frame update
    void Start()
    {
        SwitchState(new PlayerIdelState(this));
    }

   
}
