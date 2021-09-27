using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts
{
    public class PlayerKit
    {
        #region Fields
        private Color shirtColor;

        private Color shortsColor;
        #endregion

        #region Properties
        public Color ShirtColor
        {
            get
            {
                return shirtColor;
            }
            set
            {
                shirtColor = value;
            }
        }

        public Color ShortsColor
        {
            get
            {
                return shortsColor;
            }
            set
            {
                shortsColor = value;
            }
        }
        #endregion

        #region Constructors
        public PlayerKit() { }

        public PlayerKit(Color pShirtColor, Color pShortsColor)
        {
            this.ShirtColor = pShirtColor;
            this.ShortsColor = pShortsColor;
        }
        #endregion

    }
}
