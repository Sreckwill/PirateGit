using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _StateMechine : MonoBehaviour
{
    private _States currentState;
    private _PlayerIdelState_ _idelState;
    private void Start()
    {
        _idelState = new _PlayerIdelState_(this);
        currentState = _idelState;
        currentState?.EnterState();
    }

    private void Update()
    {
        currentState?.UpdateState();
    }

    public void SwitchState(_States newState)
    {
        currentState?.ExitState();
        currentState = newState;
        currentState?.EnterState();
    }
}
