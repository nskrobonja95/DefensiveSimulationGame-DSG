using Assets.Custom.Scripts;
using Assets.Custom.Scripts.FootballLogic;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayers : MonoBehaviour
{
    private GameManager gameManager;

    public GameObject playerMenu;
    public GameObject playerMenu2;

    private List<GameObject> generatedObjects;

    // Start is called before the first frame update
    void Start()
    {

        generatedObjects = new List<GameObject>();
        gameManager = GameManager.Instance;
        gameManager._Formation.UpdatePlayers();
        GameObject instance = Instantiate(playerMenu, gameObject.transform) as GameObject;
        instance.GetComponent<RectTransform>().localPosition = GetPlayerMenuPosition(gameManager.Players[0]);
        generatedObjects.Add(instance);

        GameObject instance1 = Instantiate(playerMenu, gameObject.transform) as GameObject;
        instance1.GetComponent<RectTransform>().localPosition = GetPlayerMenuPosition(gameManager.Players[1]);
        generatedObjects.Add(instance1);

        GameObject instance2 = Instantiate(playerMenu, gameObject.transform) as GameObject;
        instance2.GetComponent<RectTransform>().localPosition = GetPlayerMenuPosition(gameManager.Players[2]);
        generatedObjects.Add(instance2);

        GameObject instance3 = Instantiate(playerMenu, gameObject.transform) as GameObject;
        instance3.GetComponent<RectTransform>().localPosition = GetPlayerMenuPosition(gameManager.Players[3]);
        generatedObjects.Add(instance3);

        instance3 = Instantiate(playerMenu, gameObject.transform) as GameObject;
        instance3.GetComponent<RectTransform>().localPosition = GetPlayerMenuPosition(gameManager.Players[4]);
        generatedObjects.Add(instance3);

        instance3 = Instantiate(playerMenu, gameObject.transform) as GameObject;
        instance3.GetComponent<RectTransform>().localPosition = GetPlayerMenuPosition(gameManager.Players[5]);
        generatedObjects.Add(instance3);

        instance3 = Instantiate(playerMenu, gameObject.transform) as GameObject;
        instance3.GetComponent<RectTransform>().localPosition = GetPlayerMenuPosition(gameManager.Players[6]);
        generatedObjects.Add(instance3);

        instance3 = Instantiate(playerMenu, gameObject.transform) as GameObject;
        instance3.GetComponent<RectTransform>().localPosition = GetPlayerMenuPosition(gameManager.Players[7]);
        generatedObjects.Add(instance3);

        instance3 = Instantiate(playerMenu, gameObject.transform) as GameObject;
        instance3.GetComponent<RectTransform>().localPosition = GetPlayerMenuPosition(gameManager.Players[8]);
        generatedObjects.Add(instance3);

        instance3 = Instantiate(playerMenu, gameObject.transform) as GameObject;
        instance3.GetComponent<RectTransform>().localPosition = GetPlayerMenuPosition(gameManager.Players[9]);
        generatedObjects.Add(instance3);
    }

    private Vector3 GetPlayerMenuPosition(Player player)
    {
        float translationFactor = 65 * 3 / 2;
        float scaleFactor = 3.0f;
        return new Vector3(player.HomePosition.z * scaleFactor, 
                            player.HomePosition.x * scaleFactor - translationFactor, 
                             -1.1f);
    }

    // Update is called once per frame
    void Update()
    {
        var i = 0;
        foreach(GameObject go in generatedObjects)
        {
            go.GetComponent<RectTransform>().localPosition = GetPlayerMenuPosition(gameManager.Players[i]);
            ++i;
        }
    }
}
