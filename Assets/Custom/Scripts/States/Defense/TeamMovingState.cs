using Assets.Custom.Scripts.FootballLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Custom.Scripts.States.Defense
{
    class TeamMovingState : State
    {
        #region variables
        private DefensiveTeam defensiveTeam;
        private StateMachine stateMachine;
        #endregion

        #region constructors
        public TeamMovingState(DefensiveTeam defensiveTeam, StateMachine stateMachine)
        {
            this.defensiveTeam = defensiveTeam;
            this.stateMachine = stateMachine;
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
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();
            //defensiveTeam.formation.updatePlayerPositions(defensiveTeam.ballObj.transform.position, defensiveTeam.fieldWidth, defensiveTeam.fieldLength);
            //stateMachine.ChangeState(defensiveTeam.idleState);
        }

        public override void Exit()
        {
            base.Exit();
        }
        #endregion
    }
}
