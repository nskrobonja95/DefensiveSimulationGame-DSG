using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts.FootballLogic
{
    public class FootballField
    {
        private int width;

        private int height;

        private float offset;

        private Vector2 upperLeftPoint;

        private Vector2 lowerLeftPoint;

        private Vector2 upperRightPoint;

        private Vector2 lowerRightPoint;

        public FootballField(int width, int height, float offset)
        {
            this.Width = width;
            this.Height = height;
            this.offset = offset;
            upperLeftPoint = new Vector2(0.0f, 0.0f);
            lowerLeftPoint = new Vector2(width, 0.0f);
            upperRightPoint = new Vector2(0.0f, height);
            lowerRightPoint = new Vector2(width, height);
        }

        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public float Offset { get => offset; set => offset = value; }
        public Vector2 UpperLeftPoint { get => upperLeftPoint; set => upperLeftPoint = value; }
        public Vector2 LowerLeftPoint { get => lowerLeftPoint; set => lowerLeftPoint = value; }
        public Vector2 UpperRightPoint { get => upperRightPoint; set => upperRightPoint = value; }
        public Vector2 LowerRightPoint { get => lowerRightPoint; set => lowerRightPoint = value; }
    }
}
