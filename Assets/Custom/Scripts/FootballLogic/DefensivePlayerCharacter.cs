using Assets.Custom.Scripts.Formations;
using Assets.Custom.Scripts.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts.FootballLogic
{
    public class DefensivePlayerCharacter : MonoBehaviour
    {

        #region variables
        public StateMachine animatorStateMachine;
        public StateMachine movementStateMachine;
        public State idleState;
        public State runningState;

        //public DefensiveTeam team;
        public TeamFormation formation;
        public Player playerInfo;
        public Vector3 homePosition;
        public GameManager gameManager;
        public GameObject ballObj;
        public int idxOfPlayerInList;
        public bool regionChanged;
        #endregion

        #region MonoBehaviour callbacks
        private void Start()
        {
            //initialisation
            gameManager = GameManager.Instance;
            homePosition = gameObject.transform.position;
            formation = GameManager.Instance._TeamFormation;
            for (int i = 0; i < formation.Players.Count; i++)
            {
                if (formation.Players[i].HomePosition == homePosition)
                {
                    playerInfo = formation.Players[i];
                    idxOfPlayerInList = i;
                }
            }

            //animator
            animatorStateMachine = new StateMachine();
            idleState = new IdleState(this, animatorStateMachine);
            runningState = new RunningState(this, animatorStateMachine);
            animatorStateMachine.Initialise(runningState);
            //movement
            movementStateMachine = new StateMachine(); 
        }

        private void Update()
        {
            animatorStateMachine.CurrentState.HandleInput();

            animatorStateMachine.CurrentState.LogicUpdate();            

        }
        #endregion

        #region methods
        //public Vector3 CalculatePlayerPosition()
        //{

        //}
        #endregion

    }
}
