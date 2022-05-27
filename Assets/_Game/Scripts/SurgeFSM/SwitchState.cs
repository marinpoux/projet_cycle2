using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pixelplacement
{
[RequireComponent(typeof(StateMachine))]

    public class SwitchState : MonoBehaviour
    {
        private StateMachine stateMachine;

        [SerializeField] public Action SwitchAction;
        public State newState;

        private void Start()
        {
            stateMachine = GetComponent<StateMachine>();
        }

        private void OnEnable()
        {
            GameOverTrigger.GameOver += SwitchToState;
        }

        private void SwitchToState()
        {
            stateMachine.ChangeState(newState.name);
        }
    }
}
