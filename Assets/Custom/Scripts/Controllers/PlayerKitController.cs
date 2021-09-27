using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts.Controllers
{
    public class PlayerKitController
    {
        static GameManager _gameManager = GameManager.Instance;

        public static void UpdateDefensivePlayerKits(List<GameObject> players)
        {
            foreach (GameObject defPlayer in players)
            {
                GameObject spine = defPlayer.transform.GetChild(0).gameObject;
                spine.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = _gameManager.SelectedHomeKit.ShirtColor;
                spine.transform.GetChild(2).gameObject.transform.GetChild(0).
                    transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = _gameManager.SelectedHomeKit.ShirtColor;
                spine.transform.GetChild(3).gameObject.transform.GetChild(0).
                    transform.GetChild(1).gameObject.GetComponent<Renderer>().material.color = _gameManager.SelectedHomeKit.ShirtColor;
                spine.transform.GetChild(4).gameObject.transform.GetChild(0).
                    GetComponent<Renderer>().material.color = _gameManager.SelectedHomeKit.ShortsColor;
                spine.transform.GetChild(5).gameObject.transform.GetChild(1).
                    GetComponent<Renderer>().material.color = _gameManager.SelectedHomeKit.ShortsColor;
            }
        }

        public static void UpdateOffensivePlayerKits(GameObject[] players)
        {
            _gameManager = GameManager.Instance;
            foreach (GameObject offPlayer in players)
            {
                GameObject spine = offPlayer.transform.GetChild(0).gameObject;
                spine.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = _gameManager.SelectedAwayKit.ShirtColor;
                spine.transform.GetChild(2).gameObject.transform.GetChild(0).
                    transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = _gameManager.SelectedAwayKit.ShirtColor;
                spine.transform.GetChild(3).gameObject.transform.GetChild(0).
                    transform.GetChild(1).gameObject.GetComponent<Renderer>().material.color = _gameManager.SelectedAwayKit.ShirtColor;
                spine.transform.GetChild(4).gameObject.transform.GetChild(0).
                    GetComponent<Renderer>().material.color = _gameManager.SelectedAwayKit.ShortsColor;
                spine.transform.GetChild(5).gameObject.transform.GetChild(1).
                    GetComponent<Renderer>().material.color = _gameManager.SelectedAwayKit.ShortsColor;
            }
        }

        public static void UpdateDefensivePlayer(GameObject player)
        {            
            GameObject spine = player.transform.GetChild(0).gameObject;
            spine.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = _gameManager.SelectedHomeKit.ShirtColor;
            spine.transform.GetChild(2).gameObject.transform.GetChild(0).
                transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = _gameManager.SelectedHomeKit.ShirtColor;
            spine.transform.GetChild(3).gameObject.transform.GetChild(0).
                transform.GetChild(1).gameObject.GetComponent<Renderer>().material.color = _gameManager.SelectedHomeKit.ShirtColor;
            spine.transform.GetChild(4).gameObject.transform.GetChild(0).
                GetComponent<Renderer>().material.color = _gameManager.SelectedHomeKit.ShortsColor;
            spine.transform.GetChild(5).gameObject.transform.GetChild(1).
                GetComponent<Renderer>().material.color = _gameManager.SelectedHomeKit.ShortsColor;
        }

        public static void UpdateOffensivePlayer(GameObject player)
        {
            GameObject spine = player.transform.GetChild(0).gameObject;
            spine.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = _gameManager.SelectedAwayKit.ShirtColor;
            spine.transform.GetChild(2).gameObject.transform.GetChild(0).
                transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = _gameManager.SelectedAwayKit.ShirtColor;
            spine.transform.GetChild(3).gameObject.transform.GetChild(0).
                transform.GetChild(1).gameObject.GetComponent<Renderer>().material.color = _gameManager.SelectedAwayKit.ShirtColor;
            spine.transform.GetChild(4).gameObject.transform.GetChild(0).
                GetComponent<Renderer>().material.color = _gameManager.SelectedAwayKit.ShortsColor;
            spine.transform.GetChild(5).gameObject.transform.GetChild(1).
                GetComponent<Renderer>().material.color = _gameManager.SelectedAwayKit.ShortsColor;
        }

        public static void UpdateSelectedKits()
        {
            _gameManager.SelectedHomeKit = new PlayerKit(_gameManager.AvailableHomeKits[_gameManager.SelectedHomeKitIndex,0], _gameManager.AvailableHomeKits[_gameManager.SelectedHomeKitIndex, 1]);
            _gameManager.SelectedAwayKit = new PlayerKit(_gameManager.AvailableAwayKits[_gameManager.SelectedAwayKitIndex, 0], _gameManager.AvailableAwayKits[_gameManager.SelectedAwayKitIndex, 1]);
        }

    }
}
