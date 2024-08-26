using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMechine : MonoBehaviour
{
    private States currentState;
    private PlayeIdelState idelState;
    private PlayerWalkingState walkingState;
    // Start is called before the first frame update
    void Start()
    {
        idelState = new PlayeIdelState(this);
        walkingState = new PlayerWalkingState(this);
        currentState = idelState;
        currentState?.EnterState();
    }

    // Update is called once per frame
    void Update()
    {
        currentState?.UpdateState();
    }
    public void SwitchState(States newState)
    {
        currentState?.ExitState();
        currentState = newState;
        currentState?.EnterState();
    }
}
