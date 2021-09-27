using Assets.Custom.Scripts.FootballLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts.Formations
{
    class TeamFormation_442 : TeamFormation
    {
        public TeamFormation_442(Vector3 ballPos, float fieldWidth, float fieldLength)
        {
            Players = new List<Player>();
            this.fieldWidth = fieldWidth;
            this.FieldLength = fieldLength;
            currentRegion = getActiveRegion(ballPos);
            newRegion = currentRegion;
        }

        public override void updatePlayerPositions(Vector3 ballPos, float fieldWidth, float fieldLength)
        {
            setup(ballPos, fieldWidth, fieldLength);
            currentRegion = getActiveRegion(ballPos);
            updateLBPosition(0);
            updateLCBPosition(1);
            updateRCBPosition(2);
            updateRBPosition(3);
            updateRMFPosition(4);
            updateLMFPosition(5);
            updateLWPosition(6);
            updateRWPosition(7);
            updateLSPosition(8);
            updateRSPosition(9);
        }

        public override void updatePlayerPosition(int idx, Vector3 ballPos)
        {
            this.ballPos = ballPos;
            currentRegion = getActiveRegion(ballPos);
            switch (idx)
            {
                case 0:
                    updateLBPosition(idx);
                    return;
                case 1:
                    updateLCBPosition(idx);
                    return;
                case 2:
                    updateRBPosition(idx);
                    return;
                case 3:
                    updateRCBPosition(idx);
                    return;
                case 4:
                    updateLMFPosition(idx);
                    return;
                case 5:
                    updateRMFPosition(idx);
                    return;
                case 6:
                    updateLWPosition(idx);
                    return;
                case 7:
                    updateRWPosition(idx);
                    return;
                case 8:
                    updateLSPosition(idx);
                    return;
                case 9:
                    updateRSPosition(idx);
                    return;
            }
        }

        public override void updateLBPosition(int idx)
        {
            switch (currentRegion)
            {
                case Region.r1:
                    Players[idx].CurrentPosition = 
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 4);
                    return;
                case Region.r2:
                    Players[idx].CurrentPosition = 
                        new Vector3(Players[idx].HomePosition.x - 3, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 19);
                    return;
                case Region.r3:
                    Players[idx].CurrentPosition = 
                        new Vector3(Players[idx].HomePosition.x + 17, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z);
                    return;
                case Region.r4:
                    Players[idx].CurrentPosition = 
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 10);
                    return;
                case Region.r5:
                    Players[idx].CurrentPosition = 
                        new Vector3(Players[idx].HomePosition.x + 10, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z - 15);
                    return;
                case Region.r6:
                    Players[idx].CurrentPosition = 
                        new Vector3(Players[idx].HomePosition.x + 10, Players[idx].HomePosition.y,
                                               Players[idx].HomePosition.z - 20);
                    return;
                default:
                    return;
            }
        }

        public override void updateLCBPosition(int idx)
        {
            switch (currentRegion)
            {
                case Region.r1:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 4);
                    return;
                case Region.r2:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 9);
                    return;
                case Region.r3:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 3, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z);
                    return;
                case Region.r4:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 10);
                    return;
                case Region.r5:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 10, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z - 15);
                    return;
                case Region.r6:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 10, Players[idx].HomePosition.y,
                                               Players[idx].HomePosition.z - 10);
                    return;
                default:
                    return;
            }
        }

        public override void updateRBPosition(int idx)
        {
            switch (currentRegion)
            {
                case Region.r1:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 4);
                    return;
                case Region.r2:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 9);
                    return;
                case Region.r3:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 3, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z);
                    return;
                case Region.r4:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 10);
                    return;
                case Region.r5:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 10, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z - 15);
                    return;
                case Region.r6:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 10, Players[idx].HomePosition.y,
                                               Players[idx].HomePosition.z - 10);
                    return;
                default:
                    return;
            }
        }

        public override void updateRCBPosition(int idx)
        {
            switch (currentRegion)
            {
                case Region.r1:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 4);
                    return;
                case Region.r2:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 9);
                    return;
                case Region.r3:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 3, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z);
                    return;
                case Region.r4:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 10);
                    return;
                case Region.r5:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 10, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z - 15);
                    return;
                case Region.r6:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 10, Players[idx].HomePosition.y,
                                               Players[idx].HomePosition.z - 10);
                    return;
                default:
                    return;
            }
        }

        public void updateLMFPosition(int idx)
        {
            switch (currentRegion)
            {
                case Region.r1:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 4);
                    return;
                case Region.r2:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 9);
                    return;
                case Region.r3:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 3, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z);
                    return;
                case Region.r4:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 10);
                    return;
                case Region.r5:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 10, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z - 15);
                    return;
                case Region.r6:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 10, Players[idx].HomePosition.y,
                                               Players[idx].HomePosition.z - 10);
                    return;
                default:
                    return;
            }
        }

        public void updateRMFPosition(int idx)
        {
            switch (currentRegion)
            {
                case Region.r1:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 4);
                    return;
                case Region.r2:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 9);
                    return;
                case Region.r3:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 3, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z);
                    return;
                case Region.r4:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 10);
                    return;
                case Region.r5:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 10, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z - 15);
                    return;
                case Region.r6:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 10, Players[idx].HomePosition.y,
                                               Players[idx].HomePosition.z - 10);
                    return;
                default:
                    return;
            }
        }

        public void updateLWPosition(int idx)
        {
            switch (currentRegion)
            {
                case Region.r1:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 4);
                    return;
                case Region.r2:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 9);
                    return;
                case Region.r3:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 3, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z);
                    return;
                case Region.r4:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 10);
                    return;
                case Region.r5:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 10, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z - 15);
                    return;
                case Region.r6:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 10, Players[idx].HomePosition.y,
                                               Players[idx].HomePosition.z - 10);
                    return;
                default:
                    return;
            }
        }

        public void updateRWPosition(int idx)
        {
            switch (currentRegion)
            {
                case Region.r1:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 4);
                    return;
                case Region.r2:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 9);
                    return;
                case Region.r3:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 3, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z);
                    return;
                case Region.r4:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 10);
                    return;
                case Region.r5:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 10, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z - 15);
                    return;
                case Region.r6:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 10, Players[idx].HomePosition.y,
                                               Players[idx].HomePosition.z - 10);
                    return;
                default:
                    return;
            }
        }

        public void updateLSPosition(int idx)
        {
            switch (currentRegion)
            {
                case Region.r1:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 4);
                    return;
                case Region.r2:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 9);
                    return;
                case Region.r3:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 3, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z);
                    return;
                case Region.r4:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 10);
                    return;
                case Region.r5:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 10, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z - 15);
                    return;
                case Region.r6:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 10, Players[idx].HomePosition.y,
                                               Players[idx].HomePosition.z - 10);
                    return;
                default:
                    return;
            }
        }

        public void updateRSPosition(int idx)
        {
            switch (currentRegion)
            {
                case Region.r1:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 4);
                    return;
                case Region.r2:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 9);
                    return;
                case Region.r3:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 3, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z);
                    return;
                case Region.r4:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z + 10);
                    return;
                case Region.r5:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 10, Players[idx].HomePosition.y,
                                            Players[idx].HomePosition.z - 15);
                    return;
                case Region.r6:
                    Players[idx].CurrentPosition =
                        new Vector3(Players[idx].HomePosition.x + 10, Players[idx].HomePosition.y,
                                               Players[idx].HomePosition.z - 10);
                    return;
                default:
                    return;
            }
        }

    }
}
