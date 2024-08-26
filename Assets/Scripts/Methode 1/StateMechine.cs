
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMechine : MonoBehaviour
{
    public State currentState;
    IdelState idelState;
    WalkingState walkingState;
    // Start is called before the first frame update
    void Start()
    {
        idelState = new IdelState(this);
        walkingState = new WalkingState(this);
        currentState = idelState;
        currentState?.EnterState();
    }

    // Update is called once per frame
    void Update()
    {
        currentState?.UpdateState();
    }
    public void SwitchState(State newState)
    {
        currentState?.ExitState();
        currentState = newState;
        currentState?.EnterState();
    }
}
