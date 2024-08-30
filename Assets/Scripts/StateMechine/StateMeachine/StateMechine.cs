using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMechine : MonoBehaviour
{
    private States _currentState;

    // Start is called before the first frame update
    void Start()
    {
        
        _currentState?.EnterState();
    }

    // Update is called once per frame
    void Update()
    {
        _currentState?.UpdateState(Time.deltaTime);
    }
    public void SwitchState(States newState)
    {
        _currentState?.ExitState();
        _currentState = newState; 
        _currentState?.EnterState();
    }
}
