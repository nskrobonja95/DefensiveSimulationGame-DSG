using Assets.Custom.Scripts.FootballLogic;
using Assets.Custom.Scripts.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Custom.Scripts.Controllers
{
    public class OffensivePlayerController : MonoBehaviour
    {
        #region variables
        public GameObject ballObj;

        private GameManager _gameManager;
        #endregion

        #region MonoBehaviour callbacks
        private void Start()
        {
            _gameManager = GameManager.Instance;
            InitialiseInBallPossesion();
            GameObject rb_offense = GameObject.Find("RightBack_Offense2");
            GameObject rw_offense = GameObject.Find("RightWing_Offense2");
            GameObject cmf_offense = GameObject.Find("CentralMidfielder_Offense2");
            GameObject lcb_offense = GameObject.Find("LeftCB_Offense2");
            GameObject rcb_offense = GameObject.Find("RightCB_Offense2");
            GameObject lb_offense = GameObject.Find("LeftBack_Offense2");
            GameObject lw_offense = GameObject.Find("LeftWing_Offense2");
            _gameManager.OffensivePlayersAsGameObjects = new List<GameObject>();
            _gameManager.OffensivePlayersAsGameObjects.Add(rb_offense);
            _gameManager.ActivePlayerIdx = 0;
            _gameManager.OffensivePlayersAsGameObjects.Add(rcb_offense);
            _gameManager.OffensivePlayersAsGameObjects.Add(lcb_offense);
            _gameManager.OffensivePlayersAsGameObjects.Add(lb_offense);
            _gameManager.OffensivePlayersAsGameObjects.Add(rw_offense);
            _gameManager.OffensivePlayersAsGameObjects.Add(cmf_offense);
            _gameManager.OffensivePlayersAsGameObjects.Add(lw_offense);
        }

        private void Update()
        {
            RotatePlayersTowardsBall();
        }

        #endregion

        #region Methods
        private void RotatePlayersTowardsBall()
        {
            float speed = 50.0f;
            var step = speed * Time.deltaTime;
            for (int i = 0; i < _gameManager.OffensivePlayersAsGameObjects.Count; ++i)
            {
                Vector3 targetRotation = _gameManager.OffensivePlayersAsGameObjects[i].transform.position - new Vector3(ballObj.transform.position.x, _gameManager.OffensivePlayersAsGameObjects[i].transform.position.y,
                                ballObj.transform.position.z);
                Quaternion target = Quaternion.LookRotation(targetRotation, Vector3.up);
                _gameManager.OffensivePlayersAsGameObjects[i].transform.rotation = Quaternion.RotateTowards(_gameManager.OffensivePlayersAsGameObjects[i].transform.rotation, target, step);
            }
        }

        private void InitialiseInBallPossesion()
        {
            for (int i=0; i<_gameManager._OffensivePlayers.Count; ++i)
            {                
                if (Vector3.Distance(ballObj.transform.position, _gameManager._OffensivePlayers[i].Position) < 5.0f)
                {
                    _gameManager._OffensivePlayers[i].InBallPossesion = true;                    
                    _gameManager.ActivePlayerIdx = i;
                }
                else
                    _gameManager._OffensivePlayers[i].InBallPossesion = false;
            }
        }
        #endregion

    }
}
