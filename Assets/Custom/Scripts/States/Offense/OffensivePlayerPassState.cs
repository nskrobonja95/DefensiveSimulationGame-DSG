using Assets.Custom.Scripts.FootballLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Animations;

namespace Assets.Custom.Scripts.States
{
    class OffensivePlayerPassState : State
    {
        #region variables

        private OffensivePlayerCharacter offensivePlayerCharacter;
        private StateMachine stateMachine;
        private Animator characterAnimator;
        private int numOfFramesPlayed;
        private GameManager _gameManager;

        #endregion

        #region constructors
        public OffensivePlayerPassState(OffensivePlayerCharacter offensivePlayerCharacter, StateMachine stateMachine)
        {
            this.offensivePlayerCharacter = offensivePlayerCharacter;
            this.stateMachine = stateMachine;
            _gameManager = GameManager.Instance;
            characterAnimator = offensivePlayerCharacter.GetComponent<Animator>();
        }

        #endregion

        #region methods
        public override void Enter()
        {
            base.Enter();

            //turn on animation
            characterAnimator.SetBool("passing", true);

            System.Random random = new System.Random();

            int idx;

            //find player to pass the ball to
            do
            {
                idx = random.Next(0, _gameManager._OffensivePlayers.Count);
            } while (idx == _gameManager.ActivePlayerIdx);

            //rotate player towards passing direction
            _gameManager.OffensivePlayersAsGameObjects[_gameManager.ActivePlayerIdx].transform.rotation =
                Quaternion.LookRotation(
                    _gameManager.OffensivePlayersAsGameObjects[_gameManager.ActivePlayerIdx].transform.position - _gameManager.OffensivePlayersAsGameObjects[idx].transform.position);
            _gameManager.ActivePlayerIdx = idx;

            //set ball position
            Vector3 from = new Vector3(offensivePlayerCharacter.transform.position.x, offensivePlayerCharacter.ballObj.transform.position.y, offensivePlayerCharacter.transform.position.z);
            Vector3 to = _gameManager.OffensivePlayersAsGameObjects[idx].transform.position;
            to.y = offensivePlayerCharacter.ballObj.transform.position.y;
            Vector3 directionOfPass = to - from;
            Vector3 dirOfPassNormalized = NormalizeVector(directionOfPass);
            _gameManager.BallPosition = from + 2.5f * dirOfPassNormalized;
        }

        private Vector3 NormalizeVector(Vector3 directionOfPass)
        {
            float x = directionOfPass.x;
            float y = directionOfPass.y;
            float z = directionOfPass.z;
            Vector3 retVal = directionOfPass / (float)Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
            return retVal;
        }

        public override void HandleInput()
        {
            base.HandleInput();
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();

            numOfFramesPlayed++;
            if(numOfFramesPlayed >= 65)
            {
                characterAnimator.SetBool("passing", false);
                numOfFramesPlayed = 0;
                stateMachine.ChangeState(new OffensivePlayerIdleState(offensivePlayerCharacter, offensivePlayerCharacter.stateMachine));
                //offensivePlayerCharacter.idleState
            }
        }

        public override void Exit()
        {
            base.Exit();

            offensivePlayerCharacter.InBallPossesion = false;

            _gameManager.BallPosition = new Vector3(
                _gameManager._OffensivePlayers[_gameManager.ActivePlayerIdx].Position.x,
                   _gameManager.BallPosition.y,
                     _gameManager._OffensivePlayers[_gameManager.ActivePlayerIdx].Position.z - 3.15f);
        }

        #endregion

    }
}
