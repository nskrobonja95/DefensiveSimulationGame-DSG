using UnityEngine;

namespace Assets.Custom.Scripts.FootballLogic
{
    public abstract class PlayerState
    {
        #region fields

        private Vector3 homePosition;

        #endregion

        #region properties

        public Vector3 HomePosition
        {
            get { return homePosition; }
            set
            {
                homePosition = value;
            }
        }

        #endregion

        #region methods

        public abstract Vector3 CalculatePlayerPosition(Vector3 ballPosition);

        public abstract void CalculatePlayerHomePosition();

        #endregion

    }
}