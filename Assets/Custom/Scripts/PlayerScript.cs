using Assets.Custom.Scripts.FootballLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts
{
    class PlayerScript : MonoBehaviour
    {
        private PlayerState currentState;

        private GameObject ballObj;

        private void Start()
        {
            currentState.CalculatePlayerHomePosition();
            ballObj = GameObject.Find("BallObj");
        }

        private void Update()
        {
            currentState.CalculatePlayerPosition(ballObj.transform.position);
        }
    }
}
