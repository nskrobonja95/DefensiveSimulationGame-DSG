using Assets.Custom.Scripts.FootballLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Custom.Scripts.States
{
    public class StateMachine
    {
        private State currentState;

        public State CurrentState
        {
            get { return currentState; }
            set { currentState = value; }
        }

        public void Initialise(State startingState)
        {
            CurrentState = startingState;
            startingState.Enter();
        }

        public void ChangeState(State newState)
        {
            CurrentState.Exit();

            CurrentState = newState;
            CurrentState.Enter();
        }
    }
}
