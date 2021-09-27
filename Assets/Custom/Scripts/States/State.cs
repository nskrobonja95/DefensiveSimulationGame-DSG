using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts.States
{
    public class State
    {
        public virtual void Enter() { }

        public virtual void HandleInput() { }

        public virtual void LogicUpdate() { }

        public virtual void Exit() { }

    }
}
