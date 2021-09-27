using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts.Movements.Formation_4231
{
    class LeftWing_4231 : PlayerMovement
    {
        protected override void CalculateBestPosition(Vector3 homePosition, Vector3 ballPosition, int fieldWidth, int fieldLength)
        {
            findActiveRegion(ballPosition, fieldWidth, fieldLength);

            switch (ballRegion)
            {
                case BallRegion.RightBack_Reg:
                    newPosition = new Vector3(HomePosition.x + 3, HomePosition.y,
                                                HomePosition.z + 15);
                    return;
                case BallRegion.RightWing_Reg:
                    newPosition = new Vector3(HomePosition.x + 5, HomePosition.y,
                                                HomePosition.z + 4);
                    return;
                case BallRegion.RightCB_Reg:
                    newPosition = new Vector3(HomePosition.x + 7, HomePosition.y,
                                                HomePosition.z + 12);
                    return;
                case BallRegion.LeftCB_Reg:
                    newPosition = new Vector3(HomePosition.x + 3, HomePosition.y,
                                                HomePosition.z);
                    return;
                case BallRegion.CenterMidfielder_Reg:
                    newPosition = newPosition = new Vector3(HomePosition.x + 6, HomePosition.y,
                                            HomePosition.z + 5);
                    return;
                case BallRegion.LeftBack_Reg:
                    newPosition = new Vector3(HomePosition.x + 10, HomePosition.y,
                                                HomePosition.z + 2);
                    return;
                case BallRegion.LeftWing_Reg:
                    newPosition = new Vector3(HomePosition.x + 9, HomePosition.y,
                                                   HomePosition.z + 4);
                    return;
                case BallRegion.NonRegion:
                    newPosition = new Vector3(HomePosition.x, HomePosition.y,
                                                   HomePosition.z);
                    return;
            }
        }
    }
}
