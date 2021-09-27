using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts.FootballLogic
{
    class LeftBackPlayerState : PlayerState
    {
        public override void CalculatePlayerHomePosition()
        {
            HomePosition = new Vector3(-37.9f, -8.4f, 6.0f);
        }

        public override Vector3 CalculatePlayerPosition(Vector3 ballPosition)
        {
            throw new NotImplementedException();
        }
    }
}
