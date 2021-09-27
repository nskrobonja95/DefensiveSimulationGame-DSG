using Assets.Custom.Scripts.FootballLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts.States
{
    class OffensivePlayerIdleState : State
    {
        #region variables

        private OffensivePlayerCharacter offensivePlayerCharacter;
        private StateMachine stateMachine;
        private bool passBallKeyPressed;

        #endregion

        #region Constructors
        public OffensivePlayerIdleState(OffensivePlayerCharacter offensivePlayerCharacter, StateMachine stateMachine)
        {
            this.offensivePlayerCharacter = offensivePlayerCharacter;
            this.stateMachine = stateMachine;
            this.passBallKeyPressed = false;
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

            passBallKeyPressed = Input.GetKeyDown(KeyCode.P);
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();

            if (passBallKeyPressed && offensivePlayerCharacter.InBallPossesion)
            {
                passBallKeyPressed = false;
                this.stateMachine.ChangeState(new OffensivePlayerPassState(offensivePlayerCharacter, offensivePlayerCharacter.stateMachine));
                //this.offensivePlayerCharacter.passState
            }
        }

        public override void Exit()
        {
            base.Exit();
        }

        #endregion
    }
}
