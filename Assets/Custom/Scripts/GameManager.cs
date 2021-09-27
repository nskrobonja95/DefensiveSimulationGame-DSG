using Assets.Custom.Scripts.FootballLogic;
using Assets.Custom.Scripts.Formations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts
{
    
    public class GameManager : MonoBehaviour
    {
        #region Fields
        //public GameObject ballObj;

        private Vector3 ballPosition;

        private float fieldWidth = 65;

        private float fieldLength = 138;

        private Formation _formation;

        private TeamFormation _teamFormation;

        private List<Player> players;

        private List<GameObject> defensivePlayersAsGameObjects;

        private List<OffensivePlayer> _offensivePlayers;

        private List<GameObject> offensivePlayersAsGameObjects;

        private int activePlayerIdx;

        private bool coachMode;

        private PlayerKit selectedHomeKit;

        private PlayerKit selectedAwayKit;

        private int selectedHomeKitIndex;

        private int selectedAwayKitIndex;

        private int numOfKits;

        private Color[,] availableHomeKits;

        private Color[,] availableAwayKits;

        private static GameManager _instance;
        #endregion

        #region Properties
        public Vector3 BallPosition
        {
            get { return ballPosition; }
            set { ballPosition = value; }
        }

        public float FieldWidth
        {
            get { return fieldWidth; }
            set
            {
                fieldWidth = value;
            }
        }

        public float FieldLength
        {
            get { return fieldLength; }
            set
            {
                fieldLength = value;
            }
        }

        public Formation _Formation
        {
            get { return _formation; }
            set { _formation = value; }
        }

        public TeamFormation _TeamFormation
        {
            get { return _teamFormation; }
            set { _teamFormation = value; }
        }

        public List<Player> Players
        {
            get { return players; }
            set { players = value; }
        }

        public List<GameObject> DefensivePlayersAsGameObjects
        {
            get { return defensivePlayersAsGameObjects; }
            set { defensivePlayersAsGameObjects = value; }
        }

        public List<GameObject> OffensivePlayersAsGameObjects
        {
            get { return offensivePlayersAsGameObjects; }
            set { offensivePlayersAsGameObjects = value; }
        }

        public int ActivePlayerIdx
        {
            get { return activePlayerIdx; }
            set { activePlayerIdx = value; }
        }

        public List<OffensivePlayer> _OffensivePlayers
        {
            get { return _offensivePlayers; }
            set { _offensivePlayers = value; }
        }

        public Color[,] AvailableHomeKits
        {
            get { return availableHomeKits; }
            set { availableHomeKits = value; }
        }

        public Color[,] AvailableAwayKits
        {
            get { return availableAwayKits; }
            set { availableAwayKits = value; }
        }

        public int SelectedHomeKitIndex
        {
            get { return selectedHomeKitIndex; }
            set { selectedHomeKitIndex = value; }
        }

        public int SelectedAwayKitIndex
        {
            get { return selectedAwayKitIndex; }
            set { selectedAwayKitIndex = value; }
        }

        public int NumOfKits
        {
            get { return numOfKits; }
            set { numOfKits = value; }
        }

        public bool CoachMode
        {
            get { return coachMode; }
            set { coachMode = value; }
        }

        public PlayerKit SelectedHomeKit
        {
            get { return selectedHomeKit; }
            set { selectedHomeKit = value; }
        }

        public PlayerKit SelectedAwayKit
        {
            get { return selectedAwayKit; }
            set { selectedAwayKit = value; }
        }

        public static GameManager Instance 
        {
            get 
            {
                return _instance;
            }
                
            private set
            {
                _instance = value;
            }
        }
        #endregion

        #region MonoBehaviour callbacks

        private void Awake()
        {
            if(Instance != null && Instance != this)
            {
                Destroy(this.gameObject);
            } else
            {
                DontDestroyOnLoad(gameObject);                
                this._Formation = new Formation_4231(); // izvuci podatak pomocu serijalizacije ili uz pomoc PlayerPrefs                
                Instance = this;
                this._Formation.UpdatePlayers();
                this._OffensivePlayers = new List<OffensivePlayer>();
                offensivePlayersAsGameObjects = new List<GameObject>();
                //CreateOffensivePlayers();
                //InitialiseTeamFormation();
                this.AvailableHomeKits = new Color[3, 2];
                this.AvailableHomeKits[0, 0] = new Color(1.0f, 0.0f, 0.0f);
                this.AvailableHomeKits[0, 1] = new Color(1.0f, 1.0f, 1.0f);
                this.AvailableHomeKits[1, 0] = new Color(0.003f, 0.799f, 0.799f);
                this.AvailableHomeKits[1, 1] = new Color(0f, 0f, 0f);
                this.AvailableHomeKits[2, 0] = new Color(0f, 0f, 1f);
                this.AvailableHomeKits[2, 1] = new Color(1f, 1f, 0f);
                this.AvailableAwayKits = new Color[3, 2];
                this.AvailableAwayKits[0, 0] = new Color(0.0f, 1.0f, 0.0f);
                this.AvailableAwayKits[0, 1] = new Color(1.0f, 1.0f, 1.0f);
                this.AvailableAwayKits[1, 0] = new Color(1f, 1f, 1f);
                this.AvailableAwayKits[1, 1] = new Color(0f, 0f, 0f);
                this.AvailableAwayKits[2, 0] = new Color(1f, 0.2f, 0.012f);
                this.AvailableAwayKits[2, 1] = new Color(0f, 0f, 0f);
                this.NumOfKits = 3;
                this.SelectedHomeKitIndex = 0;
                this.SelectedAwayKitIndex = 0;
                this.SelectedAwayKit = new PlayerKit(AvailableAwayKits[selectedAwayKitIndex,0], AvailableAwayKits[selectedAwayKitIndex,1]);
                this.SelectedHomeKit = new PlayerKit(AvailableHomeKits[selectedHomeKitIndex, 0], AvailableHomeKits[selectedHomeKitIndex, 1]);
            }
        }

        private void InitialiseTeamFormation()
        {
            _TeamFormation.FieldWidth = FieldWidth;
            _TeamFormation.FieldLength = FieldLength;

            Player player;

            player = new Player();

            GameObject lb = GameObject.Find("LeftBack_Defense");
            player.HomePosition = lb.transform.position;
            player.CurrentPosition = lb.transform.position;
            player.TeamPositionName = "Left Back";
            player.TeamPositionCode = "LB";
            _TeamFormation.Players.Add(player);

            player = new Player();
            GameObject lcb = GameObject.Find("LeftCentralBack_Defense");
            player.HomePosition = lcb.transform.position;
            player.CurrentPosition = lcb.transform.position;
            player.TeamPositionName = "Left Central Back";
            player.TeamPositionCode = "LCB";
            _TeamFormation.Players.Add(player);

            player = new Player();
            GameObject rcb = GameObject.Find("RightCentralBack_Defense");
            player.HomePosition = rcb.transform.position;
            player.CurrentPosition = rcb.transform.position;
            player.TeamPositionName = "Right Central Back";
            player.TeamPositionCode = "RCB";
            _TeamFormation.Players.Add(player);

            player = new Player();
            GameObject rb = GameObject.Find("RightBack_Defense");
            player.HomePosition = rb.transform.position;
            player.CurrentPosition = rb.transform.position;
            player.TeamPositionName = "Right Back";
            player.TeamPositionCode = "RCB";
            _TeamFormation.Players.Add(player);

            player = new Player();
            GameObject rmf = GameObject.Find("LeftDefensiveMidfielder_Defense");
            player.HomePosition = rmf.transform.position;
            player.CurrentPosition = rmf.transform.position;
            player.TeamPositionName = "Right Midfielder";
            player.TeamPositionCode = "RMF";
            _TeamFormation.Players.Add(player);

            player = new Player();
            GameObject lmf = GameObject.Find("RightDefensiveMidfielder_Defense");
            player.HomePosition = lmf.transform.position;
            player.CurrentPosition = lmf.transform.position;
            player.TeamPositionName = "Left Midfielder";
            player.TeamPositionCode = "Lmf";
            _TeamFormation.Players.Add(player);

            player = new Player();
            GameObject rw = GameObject.Find("RightWing_Defense");
            player.HomePosition = rw.transform.position;
            player.CurrentPosition = rw.transform.position;
            player.TeamPositionName = "Right Wing";
            player.TeamPositionCode = "RW";
            _TeamFormation.Players.Add(player);

            player = new Player();
            GameObject lw = GameObject.Find("LeftWing_Defense");
            player.HomePosition = lw.transform.position;
            player.CurrentPosition = lw.transform.position;
            player.TeamPositionName = "Left Wing";
            player.TeamPositionCode = "LW";
            _TeamFormation.Players.Add(player);

            player = new Player();
            GameObject ls = GameObject.Find("LeftStriker_Defense");
            player.HomePosition = ls.transform.position;
            player.CurrentPosition = ls.transform.position;
            player.TeamPositionName = "Left Striker";
            player.TeamPositionCode = "LS";
            _TeamFormation.Players.Add(player);

            player = new Player();
            GameObject rs = GameObject.Find("RightStriker_Defense");
            player.HomePosition = rs.transform.position;
            player.CurrentPosition = rs.transform.position;
            player.TeamPositionName = "Right Striker";
            player.TeamPositionCode = "RS";
            _TeamFormation.Players.Add(player);
        }

        #endregion

        #region Methods
        public void CreateOffensivePlayers()
        {
            this._OffensivePlayers = new List<OffensivePlayer>();

            for (int i = 0; i < 7; ++i)
            {
                this._OffensivePlayers.Add(new OffensivePlayer());
            }
            GameObject rb_offense = GameObject.Find("RightBack_Offense2");
            GameObject rw_offense = GameObject.Find("RightWing_Offense2");
            GameObject cmf_offense = GameObject.Find("CentralMidfielder_Offense2");
            GameObject lcb_offense = GameObject.Find("LeftCB_Offense2");
            GameObject rcb_offense = GameObject.Find("RightCB_Offense2");
            GameObject lb_offense = GameObject.Find("LeftBack_Offense2");
            GameObject lw_offense = GameObject.Find("LeftWing_Offense2");
            offensivePlayersAsGameObjects = new List<GameObject>();
            _OffensivePlayers[0].Position = rb_offense.transform.position;
            offensivePlayersAsGameObjects.Add(rb_offense);
            this.ActivePlayerIdx = 0;
            _OffensivePlayers[1].Position = rcb_offense.transform.position;
            offensivePlayersAsGameObjects.Add(rcb_offense);
            _OffensivePlayers[2].Position = lcb_offense.transform.position;
            offensivePlayersAsGameObjects.Add(lcb_offense);
            _OffensivePlayers[3].Position = lb_offense.transform.position;
            offensivePlayersAsGameObjects.Add(lb_offense);
            _OffensivePlayers[4].Position = rw_offense.transform.position;
            offensivePlayersAsGameObjects.Add(rw_offense);
            _OffensivePlayers[5].Position = cmf_offense.transform.position;
            offensivePlayersAsGameObjects.Add(cmf_offense);
            _OffensivePlayers[6].Position = lw_offense.transform.position;
            offensivePlayersAsGameObjects.Add(lw_offense);
        }

        #endregion
    }
}
