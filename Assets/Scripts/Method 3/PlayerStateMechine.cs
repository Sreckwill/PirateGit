using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMechine : MonoBehaviour
{
    private PlayerStates currentState;
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
    public void SwitchState(PlayerStates newState)
    {
        currentState?.ExitState();
        currentState = newState;
        currentState?.EnterState();
    }
}
