using Assets.Custom.Scripts.FootballLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts.States
{
    public class RunningState : State
    {
        #region variables
        private DefensivePlayerCharacter defensivePlayerCharacter;
        private StateMachine stateMachine;
        private Animator characterAnimator;
        private Vector3 bestPosition;
        #endregion

        #region constructors
        public RunningState(DefensivePlayerCharacter defensivePlayerCharacter, StateMachine stateMachine)
        {
            this.defensivePlayerCharacter = defensivePlayerCharacter;
            this.stateMachine = stateMachine;
            bestPosition = new Vector3();
        }
        #endregion

        #region methods
        public override void Enter()
        {
            base.Enter();
            defensivePlayerCharacter.formation.updatePlayerPosition(
                                                 defensivePlayerCharacter.idxOfPlayerInList,
                                                 defensivePlayerCharacter.ballObj.transform.position);

            characterAnimator = defensivePlayerCharacter.GetComponent<Animator>();
            characterAnimator.SetBool("Running", true);

            bestPosition = defensivePlayerCharacter.playerInfo.CurrentPosition;
        }

        public override void HandleInput()
        {
            base.HandleInput();
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();
            Vector3 orientation = bestPosition - defensivePlayerCharacter.transform.position;
            if(orientation != Vector3.zero)
                defensivePlayerCharacter.transform.rotation = Quaternion.LookRotation(orientation);
            defensivePlayerCharacter.transform.position = Vector3.MoveTowards(defensivePlayerCharacter.transform.position, bestPosition,
                               0.099f);
            if (this.defensivePlayerCharacter.transform.position == bestPosition)
            {
                characterAnimator.SetBool("Running", false);
                stateMachine.ChangeState(defensivePlayerCharacter.idleState);
            }                
        }

        public override void Exit()
        {
            base.Exit();
        }
        #endregion
    }
}
