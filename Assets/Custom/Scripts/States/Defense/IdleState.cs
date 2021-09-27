using Assets.Custom.Scripts.FootballLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts.States
{
    public class IdleState : State
    {
        #region variables
        private DefensivePlayerCharacter defensivePlayerCharacter;
        private StateMachine stateMachine;
        private bool passBallKeyPressed;
        #endregion

        #region constructors
        public IdleState(DefensivePlayerCharacter defensivePlayerCharacter, StateMachine stateMachine)
        {
            this.defensivePlayerCharacter = defensivePlayerCharacter;
            this.stateMachine = stateMachine;
            this.passBallKeyPressed = false;
        }
        #endregion

        #region methods
        public override void Enter()
        {
            base.Enter();
            passBallKeyPressed = false;
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
                if (defensivePlayerCharacter.formation.regionChanged(defensivePlayerCharacter.gameManager.BallPosition))
                {
                    passBallKeyPressed = false;
                    stateMachine.ChangeState(this.defensivePlayerCharacter.runningState);
                }                    
            }

        }

        public override void Exit()
        {
            base.Exit();
            //defensivePlayerCharacter.formation.updatePlayerPositions(
            //    defensivePlayerCharacter.ballObj.transform.position, 
            //        defensivePlayerCharacter.formation.FieldWidth,
            //            defensivePlayerCharacter.formation.FieldLength);

            //bolja varijanta:
            
        }
        #endregion
    }
}
