using Assets.Custom.Scripts.FootballLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts.Formations
{
    public abstract class TeamFormation
    {
        #region variables
        private List<Player> players;
        protected Vector3 ballPos;
        protected float fieldWidth;
        protected float fieldLength;
        public enum Region { r1, r2, r3, r4, r5, r6, NonRegion };        
        public Region currentRegion;
        public Region newRegion;
        #endregion

        #region properties
        public List<Player> Players
        {
            get { return players; }
            set { players = value; }
        }
        public float FieldWidth
        {
            get { return fieldWidth; }
            set { fieldWidth = value; }
        }

        public float FieldLength
        {
            get { return fieldLength; }
            set { fieldLength = value; }
        }
        #endregion
        protected void setup(Vector3 ballPos, float fieldWidth, float fieldLength)
        {
            this.ballPos = ballPos;
            this.fieldWidth = fieldWidth;
            this.fieldLength = fieldLength;            
        }

        public abstract void updatePlayerPosition(int idx, Vector3 ballPos);

        public abstract void updatePlayerPositions(Vector3 ballPos, float fieldWidth, float fieldLength);

        public abstract void updateLBPosition(int idx);

        public abstract void updateLCBPosition(int idx);

        public abstract void updateRCBPosition(int idx);

        public abstract void updateRBPosition(int idx);
        
        public bool regionChanged(Vector3 ballPos)
        {
            Region activeReg = getActiveRegion(ballPos);
            if (activeReg != currentRegion)
            {
                currentRegion = activeReg;
                return true;
            }
            return false;
        }

        public Region getActiveRegion(Vector3 ballPos) 
        {
            if (ballPos.z <= fieldLength / 2 - 15)
                return Region.NonRegion;

            if (0f <= ballPos.x && ballPos.x <= fieldWidth / 3)
            {
                //region 1
                if (fieldLength / 2 - 15 <= ballPos.z && ballPos.z <= 80)
                {
                    return Region.r1;
                }
                //region 2
                else
                {
                    return Region.r2;
                }
            }
            else if (fieldWidth / 3 <= ballPos.x && ballPos.x <= (fieldWidth * 2) / 3)
            {
                //region 3
                if (fieldLength / 2 <= ballPos.z && ballPos.z <= 80)
                {
                    return Region.r3;
                }
                //region 4
                else
                {
                    return Region.r4;
                }
            }
            else
            {
                //region 5
                if (fieldLength / 2 <= ballPos.z && ballPos.z <= 80)
                {
                    return Region.r5;
                }
                //region 6
                else
                {
                    return Region.r6;
                }
            }
        }

    }
}
