using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class States 
{
    public abstract void EnterState();
    public abstract void UpdateState(float deltaTime);
    public abstract void ExitState();
}
