using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PPStateMechine : PState
{
    public PStateMechine stateMechine;
    public PPStateMechine(PStateMechine stateMechine)
    {
        this.stateMechine = stateMechine;
    }
}
