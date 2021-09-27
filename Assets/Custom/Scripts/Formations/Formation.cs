using Assets.Custom.Scripts.FootballLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts
{
    public abstract class Formation
    {
        private string formationCode;

        public string FormationCode
        {
            get
            {
                return formationCode;
            }
            set
            {
                formationCode = value;
            }
        }

        public abstract void UpdatePlayers();

        public abstract void UpdatePlayerPositions(List<Player> players);

        public abstract void UpdatePlayerMovementScripts();

        public abstract Vector3 MovePlayer(Vector3 homePos);
    }
}
