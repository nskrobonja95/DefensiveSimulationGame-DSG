using Assets.Custom.Scripts.FootballLogic;
using Assets.Custom.Scripts.Movements;
using Assets.Custom.Scripts.Movements.Formation_433;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts
{
    class Formation_433 : Formation
    {

        public Formation_433()
        {
            this.FormationCode = "4-3-3";
        }

        public override Vector3 MovePlayer(Vector3 homePos)
        {
            throw new NotImplementedException();
        }

        public override void UpdatePlayerMovementScripts()
        {
            GameManager manager = GameManager.Instance;
            //leftback            
            manager.DefensivePlayersAsGameObjects[0].AddComponent<LeftBackMovement>();
            manager.DefensivePlayersAsGameObjects[1].AddComponent<LeftCentralBackMovement>();
            manager.DefensivePlayersAsGameObjects[2].AddComponent<RightCentralBackMovement>();
            manager.DefensivePlayersAsGameObjects[3].AddComponent<RightBackMovement>();
            manager.DefensivePlayersAsGameObjects[4].AddComponent<CentralDefensiveMidfielder_433>();
            manager.DefensivePlayersAsGameObjects[5].AddComponent<LeftMidfielder_433>();
            manager.DefensivePlayersAsGameObjects[6].AddComponent<RightMidfielder_433>();
            manager.DefensivePlayersAsGameObjects[7].AddComponent<LeftAttackingPlayer_433>();
            manager.DefensivePlayersAsGameObjects[8].AddComponent<RightAttackingPlayer_433>();
            manager.DefensivePlayersAsGameObjects[9].AddComponent<Striker_433>();
        }

        public override void UpdatePlayerPositions(List<Player> players)
        {
            
        }

        public override void UpdatePlayers()
        {
            GameManager manager = GameManager.Instance;

            manager.Players = new List<Player>();
            //left back
            Player player = new Player(new Vector3(8.2f, 2.8f, 46.1f));
            player.TeamPositionName = "LB";
            manager.Players.Add(player);

            //left cb
            player = new Player(new Vector3(25f, 2.8f, 31.3f));
            player.TeamPositionName = "LCB";
            manager.Players.Add(player);

            //right cb
            player = new Player(new Vector3(40f, 2.8f, 31.3f));
            player.TeamPositionName = "RCB";
            manager.Players.Add(player);

            //right back
            player = new Player(new Vector3(55f, 2.8f, 41.3f));
            player.TeamPositionName = "RB";
            manager.Players.Add(player);

            //defensive midfielder
            player = new Player(new Vector3(35.3f, 2.8f, 52.8f));
            player.TeamPositionName = "CDMF";
            manager.Players.Add(player);

            //left midfielder
            player = new Player(new Vector3(22f, 2.8f, 61f));
            player.TeamPositionName = "LMF";
            manager.Players.Add(player);

            //right midfielder
            player = new Player(new Vector3(48.1f, 2.8f, 61f));
            player.TeamPositionName = "RMF";
            manager.Players.Add(player);

            //left offensive player
            player = new Player(new Vector3(23.5f, 2.8f, 80.1f));
            player.TeamPositionName = "LW";
            manager.Players.Add(player);

            //right offensive player
            player = new Player(new Vector3(45.8f, 2.8f, 80.1f));
            player.TeamPositionName = "RW";
            manager.Players.Add(player);

            //striker
            player = new Player(new Vector3(34.9f, 2.8f, 87.2f));
            player.TeamPositionName = "CF";
            manager.Players.Add(player);
        }
    }
}
