using Assets.Custom.Scripts.FootballLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts.Movements
{
    class RightStrikerMovement : PlayerMovement 
    {
        protected override void CalculateBestPosition(Vector3 homePosition, Vector3 ballPosition, int fieldWidth, int fieldLength)
        {
            findActiveRegion(ballPosition, fieldWidth, fieldLength);

            switch (ballRegion)
            {
                case BallRegion.RightBack_Reg:
                    newPosition = new Vector3(HomePosition.x - 12, HomePosition.y,
                                                HomePosition.z + 10);
                    return;
                case BallRegion.RightWing_Reg:
                    newPosition = new Vector3(HomePosition.x - 12, HomePosition.y,
                                                HomePosition.z + 9);
                    return;
                case BallRegion.RightCB_Reg:
                    newPosition = new Vector3(HomePosition.x, HomePosition.y,
                                                HomePosition.z + 6);
                    return;
                case BallRegion.LeftCB_Reg:
                    newPosition = new Vector3(HomePosition.x + 7, HomePosition.y,
                                                HomePosition.z + 10);
                    return;
                case BallRegion.CenterMidfielder_Reg:
                    newPosition = newPosition = new Vector3(HomePosition.x, HomePosition.y,
                                            HomePosition.z + 17);
                    return;
                case BallRegion.LeftBack_Reg:
                    newPosition = new Vector3(HomePosition.x + 2, HomePosition.y,
                                                HomePosition.z + 10);
                    return;
                case BallRegion.LeftWing_Reg:
                    newPosition = new Vector3(HomePosition.x + 2, HomePosition.y,
                                                   HomePosition.z + 11);
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
                    newPosition = new Vector3(HomePosition.x - 12, HomePosition.y,
                                                HomePosition.z + 4);
                }
                //region 2
                else
                {
                    newPosition = new Vector3(HomePosition.x - 12, HomePosition.y,
                                                HomePosition.z + 9);
                }
            }
            else if (fieldWidth / 3 <= ballPosition.x && ballPosition.x <= (fieldWidth * 2) / 3)
            {
                //region 3
                if (fieldLength / 2 <= ballPosition.z && ballPosition.z <= (fieldLength * 3) / 4)
                {
                    newPosition = new Vector3(HomePosition.x + 7, HomePosition.y,
                                                HomePosition.z + 10);
                }
                //region 4
                else
                {
                    newPosition = newPosition = new Vector3(HomePosition.x, HomePosition.y,
                                            HomePosition.z + 17);
                }
            }
            else
            {
                //region 5
                if (fieldLength / 2 <= ballPosition.z && ballPosition.z <= (fieldLength * 3) / 4)
                {
                    newPosition = new Vector3(HomePosition.x + 2, HomePosition.y,
                                                HomePosition.z + 6);
                }
                //region 6
                else
                {
                    newPosition = new Vector3(HomePosition.x + 2, HomePosition.y,
                                                   HomePosition.z + 11);
                }
            }*/
        }
    }
}
