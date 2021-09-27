using Assets.Custom.Scripts.Formations;
using Assets.Custom.Scripts.States;
using Assets.Custom.Scripts.States.Defense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts.FootballLogic
{
    public class DefensiveTeam : MonoBehaviour
    {
        #region variables
        private StateMachine stateMachine;
        public State idleState;
        public State movingState;
        public List<Player> players;
        private List<GameObject> goPlayers;
        public TeamFormation formation;
        public float fieldWidth;
        public float fieldLength;
        private GameManager _gameManager;
        public GameObject ballObj;
        #endregion

        #region MonoBehaviour callbacks

        private void Start()
        {

            this.stateMachine = new StateMachine();

            this.idleState = new TeamIdleState(this, this.stateMachine);
            this.movingState = new TeamMovingState(this, this.stateMachine);

            goPlayers = _gameManager.DefensivePlayersAsGameObjects;
            

            //initialise players list
            /*players = new List<Player>();
            Player temp;
            for(int i=0; i<goPlayers.Count; i++)
            {
                temp = new Player(goPlayers[i].transform.position);
                temp.CurrentPosition = goPlayers[i].transform.position;
                players.Add(temp);
            }*/
        }

        #endregion
    }
}
