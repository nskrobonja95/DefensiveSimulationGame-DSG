using Assets.Custom.Scripts;
using Assets.Custom.Scripts.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Custom.UI
{
    class KitsMenuController : MonoBehaviour
    {

        private GameManager _gameManager;

        private GameObject defensePlayerModel;

        private GameObject offensePlayerModel;

        public Button backHomeKitBtn;

        public Button forwardHomeKitBtn;

        public Button backAwayKitBtn;

        public Button forwardAwayKitBtn;

        private void Start()
        {
            _gameManager = GameManager.Instance;
            defensePlayerModel = GameObject.Find("playerModelForUI");
            offensePlayerModel = GameObject.Find("offensivePlayerForUI");
            PlayerKitController.UpdateDefensivePlayer(defensePlayerModel);
            PlayerKitController.UpdateOffensivePlayer(offensePlayerModel);
            backHomeKitBtn.onClick.AddListener(BackHomeKitBtn_Click);
            forwardHomeKitBtn.onClick.AddListener(ForwardHomeBtn_Click);
            backAwayKitBtn.onClick.AddListener(BackAwayKitBtn_Click);
            forwardAwayKitBtn.onClick.AddListener(ForwardAwayKitBtn_Click);
        }

        public void BackHomeKitBtn_Click()
        {
            _gameManager.SelectedHomeKitIndex--;
            if (_gameManager.SelectedHomeKitIndex < 0)
                _gameManager.SelectedHomeKitIndex = _gameManager.NumOfKits - 1;
            PlayerKitController.UpdateSelectedKits();
            PlayerKitController.UpdateDefensivePlayer(defensePlayerModel);
        }

        public void ForwardHomeBtn_Click()
        {
            _gameManager.SelectedHomeKitIndex++;
            if (_gameManager.SelectedHomeKitIndex > _gameManager.NumOfKits-1)
                _gameManager.SelectedHomeKitIndex = 0;
            PlayerKitController.UpdateSelectedKits();
            PlayerKitController.UpdateDefensivePlayer(defensePlayerModel);
        }

        public void BackAwayKitBtn_Click()
        {
            _gameManager.SelectedAwayKitIndex--;
            if (_gameManager.SelectedAwayKitIndex < 0)
                _gameManager.SelectedAwayKitIndex = _gameManager.NumOfKits - 1;
            PlayerKitController.UpdateSelectedKits();
            PlayerKitController.UpdateOffensivePlayer(offensePlayerModel);
        }

        public void ForwardAwayKitBtn_Click()
        {
            _gameManager.SelectedAwayKitIndex++;
            if (_gameManager.SelectedAwayKitIndex > _gameManager.NumOfKits-1)
                _gameManager.SelectedAwayKitIndex = 0;
            PlayerKitController.UpdateSelectedKits();
            PlayerKitController.UpdateOffensivePlayer(offensePlayerModel);
        }

    }
}
