using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMechine : MonoBehaviour
{
    private States currentState;
    // Start is called before the first frame update
    void Start()
    {
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
