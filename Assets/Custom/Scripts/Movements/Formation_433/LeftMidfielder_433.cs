using Assets.Custom.Scripts.FootballLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts.Movements.Formation_433
{
    class LeftMidfielder_433 : PlayerMovement
    {
        protected override void CalculateBestPosition(Vector3 homePosition, Vector3 ballPosition, int fieldWidth, int fieldLength)
        {
            findActiveRegion(ballPosition, fieldWidth, fieldLength);

            switch (ballRegion)
            {
                case BallRegion.RightBack_Reg:
                    newPosition = new Vector3(HomePosition.x - 5, HomePosition.y,
                                                HomePosition.z + 10);
                    return;
                case BallRegion.RightWing_Reg:
                    newPosition = new Vector3(HomePosition.x - 3, HomePosition.y,
                                                HomePosition.z - 3);
                    return;
                case BallRegion.RightCB_Reg:
                    newPosition = new Vector3(HomePosition.x - 5, HomePosition.y,
                                                HomePosition.z + 10);
                    return;
                case BallRegion.LeftCB_Reg:
                    newPosition = new Vector3(HomePosition.x + 3, HomePosition.y,
                                                HomePosition.z);
                    return;
                case BallRegion.CenterMidfielder_Reg:
                    newPosition = new Vector3(HomePosition.x + 3, HomePosition.y,
                                                HomePosition.z + 1);
                    return;
                case BallRegion.LeftBack_Reg:
                    newPosition = new Vector3(HomePosition.x + 3, HomePosition.y,
                                                HomePosition.z);
                    return;
                case BallRegion.LeftWing_Reg:
                    newPosition = new Vector3(HomePosition.x + 5, HomePosition.y,
                                                   HomePosition.z - 7);
                    return;
                case BallRegion.NonRegion:
                    newPosition = new Vector3(HomePosition.x, HomePosition.y,
                                                   HomePosition.z);
                    return;
            }

            /*if (ballPosition.z <= fieldLength / 3)
                return;

            if (0f <= ballPosition.x && ballPosition.x <= fieldWidth / 3)
            {
                //region 1
                if (fieldLength / 2 <= ballPosition.z && ballPosition.z <= (fieldLength * 3) / 4)
                {
                    newPosition = new Vector3(HomePosition.x - 2, HomePosition.y,
                                                HomePosition.z + 6);
                }
                //region 2
                else
                {
                    newPosition = new Vector3(HomePosition.x - 3, HomePosition.y,
                                                HomePosition.z - 5);
                }
            }
            else if (fieldWidth / 3 <= ballPosition.x && ballPosition.x <= (fieldWidth * 2) / 3)
            {
                //region 3
                if (fieldLength / 2 <= ballPosition.z && ballPosition.z <= (fieldLength * 3) / 4)
                {
                    newPosition = new Vector3(HomePosition.x, HomePosition.y,
                                                HomePosition.z);
                }
                //region 4
                else
                {
                    newPosition = new Vector3(HomePosition.x, HomePosition.y,
                                                HomePosition.z);
                }
            }
            else
            {
                //region 5
                if (fieldLength / 2 <= ballPosition.z && ballPosition.z <= (fieldLength * 3) / 4)
                {
                    newPosition = new Vector3(HomePosition.x, HomePosition.y,
                                                HomePosition.z);
                }
                //region 6
                else
                {
                    newPosition = new Vector3(HomePosition.x, HomePosition.y,
                                                   HomePosition.z);
                }
            }*/
        }
    }
}
