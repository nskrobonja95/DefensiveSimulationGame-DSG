using Assets.Custom.Scripts.FootballLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts.States.Defense
{
    class TeamIdleState : State
    {
        #region variables
        private DefensiveTeam defensiveTeam;
        private StateMachine stateMachine;
        private bool passBallKeyPressed;
        #endregion

        #region constructors
        public TeamIdleState(DefensiveTeam defensiveTeam, StateMachine stateMachine)
        {
            this.defensiveTeam = defensiveTeam;
            this.stateMachine = stateMachine;
            passBallKeyPressed = false;
        }
        #endregion

        #region methods
        public override void Enter()
        {
            base.Enter();
        }

        public override void HandleInput()
        {
            base.HandleInput();

            if (Input.GetKeyDown(KeyCode.P))
                passBallKeyPressed = true;

        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();

            if (passBallKeyPressed)
            {
                passBallKeyPressed = false;
                this.stateMachine.ChangeState(this.defensiveTeam.movingState);
            }
        }

        public override void Exit()
        {
            base.Exit();
        }
        #endregion
    }
}
