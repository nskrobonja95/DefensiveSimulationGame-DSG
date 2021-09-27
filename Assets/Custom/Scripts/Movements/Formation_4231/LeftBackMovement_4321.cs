using Assets.Custom.Scripts.FootballLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts.Movements.Formation_4321
{
    class LeftBackMovement_4321 : PlayerMovement
    {
        protected override void CalculateBestPosition(Vector3 homePosition, Vector3 ballPosition, int fieldWidth, int fieldLength)
        {
            if (ballPosition.z <= fieldLength / 3)
                return;

            if (0f <= ballPosition.x && ballPosition.x <= fieldWidth / 3)
            {
                //region 1
                if (fieldLength / 3 <= ballPosition.z && ballPosition.z <= (fieldLength * 2) / 3)
                {
                    newPosition = new Vector3(HomePosition.x, HomePosition.y,
                                              HomePosition.z + 4);
                }
                //region 2
                else
                {
                    newPosition = new Vector3(HomePosition.x, HomePosition.y,
                                                HomePosition.z + 9);
                }
            }
            else if (fieldWidth / 3 <= ballPosition.x && ballPosition.x <= (fieldWidth * 2) / 3)
            {
                //region 3
                if (fieldLength / 3 <= ballPosition.z && ballPosition.z <= (fieldLength * 2) / 3)
                {
                    newPosition = new Vector3(HomePosition.x + 3, HomePosition.y,
                                                HomePosition.z);
                }
                //region 4
                else
                {
                    newPosition = new Vector3(HomePosition.x, HomePosition.y,
                                                HomePosition.z + 30);
                }
            }
            else
            {
                //region 5
                if (fieldLength / 3 <= ballPosition.z && ballPosition.z <= (fieldLength * 2) / 3)
                {
                    newPosition = new Vector3(HomePosition.x + 10, HomePosition.y,
                                                HomePosition.z - 15);
                }
                //region 6
                else
                {
                    newPosition = new Vector3(HomePosition.x + 10, HomePosition.y,
                                                   HomePosition.z - 10);
                }
            }
        }
    }
}
