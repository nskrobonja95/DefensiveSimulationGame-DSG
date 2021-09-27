using Assets.Custom.Scripts;
using Assets.Custom.Scripts.Controllers;
using Assets.Custom.Scripts.FootballLogic;
using Assets.Custom.Scripts.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialiseGamePlayers : MonoBehaviour
{
    public GameObject leftBack;

    public GameObject rightBack;

    public GameObject leftCentralBack;

    public GameObject rightCentralBack;

    public GameObject leftMidfielder;

    public GameObject rightMidfielder;

    public GameObject leftWing;

    public GameObject rigthWing;

    public GameObject leftStriker;

    public GameObject rightStriker;

    private GameManager gameManager;

    public GameObject gamePlayer;

    private List<GameObject> generatedDefensivePlayers;

    // Start is called before the first frame update
    void Start()
    {

        gameManager = GameManager.Instance;
        generatedDefensivePlayers = new List<GameObject>();
        Player temp;
        generatedDefensivePlayers.Add(leftBack);
        temp = new Player(leftBack.transform.position);
        gameManager.Players.Add(temp);

        leftCentralBack.transform.position = gameManager.Players[1].HomePosition;
        generatedDefensivePlayers.Add(leftCentralBack);
        temp = new Player(leftCentralBack.transform.position);
        gameManager.Players.Add(temp);

        rightCentralBack.transform.position = gameManager.Players[2].HomePosition;
        generatedDefensivePlayers.Add(rightCentralBack);
        temp = new Player(rightCentralBack.transform.position);
        gameManager.Players.Add(temp);

        rightBack.transform.position = gameManager.Players[3].HomePosition;
        generatedDefensivePlayers.Add(rightBack);
        temp = new Player(rightBack.transform.position);
        gameManager.Players.Add(temp);

        rightMidfielder.transform.position = gameManager.Players[4].HomePosition;
        generatedDefensivePlayers.Add(rightMidfielder);
        temp = new Player(rightMidfielder.transform.position);
        gameManager.Players.Add(temp);

        leftMidfielder.transform.position = gameManager.Players[5].HomePosition;
        generatedDefensivePlayers.Add(leftMidfielder);
        temp = new Player(leftMidfielder.transform.position);
        gameManager.Players.Add(temp);

        rigthWing.transform.position = gameManager.Players[6].HomePosition;
        generatedDefensivePlayers.Add(rigthWing);
        temp = new Player(rigthWing.transform.position);
        gameManager.Players.Add(temp);

        leftWing.transform.position = gameManager.Players[7].HomePosition;
        generatedDefensivePlayers.Add(leftWing);
        temp = new Player(leftWing.transform.position);
        gameManager.Players.Add(temp);

        leftStriker.transform.position = gameManager.Players[8].HomePosition;
        generatedDefensivePlayers.Add(leftStriker);
        temp = new Player(leftStriker.transform.position);
        gameManager.Players.Add(temp);

        rightStriker.transform.position = gameManager.Players[9].HomePosition;
        generatedDefensivePlayers.Add(rightStriker);
        temp = new Player(rightStriker.transform.position);
        gameManager.Players.Add(temp);

        gameManager.DefensivePlayersAsGameObjects = generatedDefensivePlayers;

        gameManager._Formation.UpdatePlayerMovementScripts();

        if (gameManager.OffensivePlayersAsGameObjects.Count == 0)
            gameManager.CreateOffensivePlayers();

        GameObject[] offensivePlayers = GameObject.FindGameObjectsWithTag("OffensivePlayer");
        PlayerKitController.UpdateOffensivePlayerKits(offensivePlayers);

        PlayerKitController.UpdateDefensivePlayerKits(gameManager.DefensivePlayersAsGameObjects);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
