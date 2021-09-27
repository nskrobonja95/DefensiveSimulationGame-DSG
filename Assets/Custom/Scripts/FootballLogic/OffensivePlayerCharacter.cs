using Assets.Custom.Scripts.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts.FootballLogic
{
    class OffensivePlayerCharacter : MonoBehaviour
    {
        #region variables
        public StateMachine stateMachine;

        //public OffensivePlayerPassState passState;

        //public OffensivePlayerIdleState idleState;

        public GameObject ballObj;

        private bool inBallPossesion;

        private float distanceToBall;

        public bool InBallPossesion
        {
            get { return inBallPossesion; }
            set { inBallPossesion = value; }
        }
        #endregion

        #region MonoBehaviour callbacks

        private void Start()
        {

            //check if the player is in ball possesion
            InBallPossesion = false;
            float distanceToBall = Vector3.Distance(
                                ballObj.transform.position, gameObject.transform.position);
            if (distanceToBall < 5.0) InBallPossesion = true;

            //state machine initialisation
            stateMachine = new StateMachine();
            //idleState = new OffensivePlayerIdleState(this, stateMachine);
            // = new OffensivePlayerPassState(this, stateMachine);

            stateMachine.Initialise(new OffensivePlayerIdleState(this, stateMachine));
        }

        private void Update()
        {
            stateMachine.CurrentState.HandleInput();
        }

        private void FixedUpdate()
        {
            distanceToBall = Vector3.Distance(
                                ballObj.transform.position, gameObject.transform.position);
            if (distanceToBall < 5.0)
                InBallPossesion = true;
            else
                InBallPossesion = false;

            //stateMachine.CurrentState.HandleInput();

            stateMachine.CurrentState.LogicUpdate();
        }

        #endregion
    }
}
