using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts.FootballLogic
{
    public class OffensivePlayer
    {
        private Vector3 position;

        private bool inBallPossesion;

        public Vector3 Position
        {
            get { return position; }
            set { position = value; }
        }

        public bool InBallPossesion
        {
            get { return inBallPossesion; }
            set { inBallPossesion = value; }
        }
    }
}
