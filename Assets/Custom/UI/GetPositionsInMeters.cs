using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPositionsInMeters : MonoBehaviour
{

    public Text ballPositionText;

    public GameObject ballObj;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        string output = "Ball position: " + ((float) Math.Round(ballObj.transform.position.z * 100f)/100f).ToString() + "m";
        ballPositionText.text = output;
    }
}
