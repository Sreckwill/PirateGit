using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PStateMechine : MonoBehaviour
{
    public PState currentState;
    public PIdelState idelState;
    public PWalkState walkingState;
    // Start is called before the first frame update
    void Start()
    {
        idelState = new PIdelState(this);
        walkingState = new PWalkState(this);
        currentState = idelState;
        currentState?.EnterState();
    }

    // Update is called once per frame
    void Update()
    {
        currentState?.UpdateState();
    }
    public void SwitchState(PState newState)
    {
        currentState?.ExitState();
        currentState = newState;
        currentState?.EnterState();
    }
}
