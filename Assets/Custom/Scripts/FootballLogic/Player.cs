using UnityEngine;

namespace Assets.Custom.Scripts.FootballLogic
{
    public class Player
    {
        #region Fields

        private Vector3 homePosition;

        private string teamPositionName;

        private string teamPositionCode;

        private Vector3 currentPosition;

        #endregion

        #region Properties

        public Vector3 HomePosition
        {
            get { return homePosition; }
            set { homePosition = value; }
        }

        public string TeamPositionName
        {
            get { return teamPositionName; }
            set { teamPositionName = value; }
        }

        public string TeamPositionCode
        {
            get { return teamPositionCode; }
            set { teamPositionCode = value; }
        }

        public Vector3 CurrentPosition
        {
            get { return currentPosition; }
            set { currentPosition = value; }
        }

        #endregion

        #region Constructors

        public Player() { }

        public Player(Vector3 position)
        {
            this.HomePosition = position;
            this.CurrentPosition = position;
        }

        #endregion

        #region methods

        #endregion
    }
}