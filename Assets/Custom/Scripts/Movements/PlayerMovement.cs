using Assets.Custom.Scripts;
using Assets.Custom.Scripts.FootballLogic;
using Assets.Custom.Scripts.States;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerMovement : MonoBehaviour
{
    #region fields
    public float PlayerSpeed;

    protected Vector3 HomePosition;

    protected GameObject ballObj;

    protected Terrain footballFieldTerrain;

    protected GameObject footballField;

    protected FootballField field;

    protected Vector3 newPosition;

    protected Vector3 orientation;

    private GameManager _gameManager;

    Animator animator;

    protected enum BallRegion { RightBack_Reg, RightWing_Reg, RightCB_Reg, LeftCB_Reg, 
                                                    CenterMidfielder_Reg, LeftBack_Reg, LeftWing_Reg, NonRegion}
    protected BallRegion ballRegion;
    #endregion


    //private PlayerState currentState;

    void Start()
    {
        _gameManager = GameManager.Instance;
        HomePosition = gameObject.transform.position;
        newPosition = HomePosition;
        ballObj = GameObject.Find("BallObj");
        //footballField = GameObject.Find("FootballFieldTerrain");
        //footballFieldTerrain = footballField.GetComponent<Terrain>();
        //field = new FootballField((int)footballFieldTerrain.terrainData.size.x,
        //     (int)footballFieldTerrain.terrainData.size.z, 0.2f);
        field = new FootballField((int)_gameManager.FieldWidth, (int)_gameManager.FieldLength, 0.2f);
        PlayerSpeed = 0.099f;
        if (this.gameObject.transform.GetChild(0).GetComponent<Animator>() != null)
        {
            animator = this.gameObject.transform.GetChild(0).GetComponent<Animator>();            
        }
        else
        {
            animator = GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CalculateBestPosition(HomePosition, ballObj.transform.position, 
            (int)_gameManager.FieldWidth, (int)_gameManager.FieldLength);
        if (gameObject.transform.position != newPosition) {
            animator.SetBool("Running", true);
            orientation = newPosition - gameObject.transform.position;
            gameObject.transform.rotation = Quaternion.LookRotation(orientation);
            gameObject.transform.position = Vector3.MoveTowards(
                gameObject.transform.position, newPosition, PlayerSpeed);
        }
        else
        {
            orientation = ballObj.transform.position - gameObject.transform.position;
            orientation.y = 0;
            gameObject.transform.rotation = Quaternion.LookRotation(orientation);
            animator.SetBool("Running", false);
        }
    }

    #region methods
    protected abstract void CalculateBestPosition(Vector3 homePosition,
        Vector3 ballPosition, int fieldWidth, int fieldLength);

    public void findActiveRegion(Vector3 ballPosition, int fieldWidth, int fieldLength)
    {
        float x = ballPosition.x; //compare with width
        float y = ballPosition.z; // compare with height

        if(y < fieldLength / 2 - 10)
        {
            ballRegion = BallRegion.NonRegion;
            return;
        }

        //right side of field
        if(x <= fieldWidth / 3 - 5)
        {
            if(y > fieldLength / 4 * 3 - 3)
                ballRegion = BallRegion.RightBack_Reg;
            else
                ballRegion = BallRegion.RightWing_Reg;
            return;
        }

        if(fieldWidth / 3 - 2 < x && x < fieldWidth / 3 * 2)
        {
            if(y > fieldLength / 4 * 3 - 2)
            {
                if (x < fieldWidth / 2)
                    ballRegion = BallRegion.RightCB_Reg;
                else
                    ballRegion = BallRegion.LeftCB_Reg;
            }
            else
            {
                ballRegion = BallRegion.CenterMidfielder_Reg;
            }
            return;
        }

        if (y > fieldLength / 4 * 3 - 5)
            ballRegion = BallRegion.LeftBack_Reg;
        else
            ballRegion = BallRegion.LeftWing_Reg;
    }

    #endregion



}
