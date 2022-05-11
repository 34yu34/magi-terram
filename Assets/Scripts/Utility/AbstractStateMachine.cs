using System;
using UnityEngine;

namespace Scripts.Utility
{
    public abstract class AbstractStateMachine : MonoBehaviour
    {
        private IState _current_state;
        

        protected void Update()
        {
            _current_state.OnUpdate();
            
            var next_state = _current_state.NextState();

            if (next_state == _current_state) return;
            
            ChangeState(next_state);
        }

        public void ChangeState(IState next_state)
        {
            _current_state.OnExit();
            _current_state = next_state;
            _current_state.OnEnter();
        }
    }
}