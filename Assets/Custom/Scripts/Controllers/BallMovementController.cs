using Assets.Custom.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementController : MonoBehaviour
{

    private GameManager _gameManager;

    private float rotX;
    private float rotZ;
    private float rotRate;

    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameManager.Instance;

        _gameManager.BallPosition = gameObject.transform.position;

        rotX = 0;
        rotZ = 0;
        rotRate = 2;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(_gameManager.BallPosition != gameObject.transform.position)
        {
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, _gameManager.BallPosition, 0.05f);           
            rotX += rotRate;
            rotZ += rotRate;
            if (rotX > 360.0f) rotX = 0.0f;
            if (rotZ > 360.0f) rotZ = 0.0f;
            gameObject.transform.localRotation = Quaternion.Euler(rotX, 0.0f, rotZ);
        }
    }
}
