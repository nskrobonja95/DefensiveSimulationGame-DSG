using Assets.Custom.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchCamera : MonoBehaviour
{
    public Camera defenseCamera;
    public Camera offenseCamera;
    public Camera sideCamera;
    public Camera coachModeCamera;

    public Button GoToCoachModeBtn;

    public List<Camera> cameras;

    public int activeCamIndex;

    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.Instance;
        activeCamIndex = 0;

        defenseCamera.enabled = false;
        offenseCamera.enabled = false;
        sideCamera.enabled = true;

        coachModeCamera.enabled = false;

        cameras = new List<Camera>();        
        cameras.Add(sideCamera); 
        cameras.Add(offenseCamera);
        cameras.Add(defenseCamera);

        //GoToCoachModeBtn.onClick.AddListener(ActivateCoachMode);
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameManager.CoachMode)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                cameras[activeCamIndex].enabled = false;
                if (activeCamIndex == cameras.Count - 1) activeCamIndex = -1;
                ++activeCamIndex;
                cameras[activeCamIndex].enabled = true;
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                ActivateCoachMode();
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadSceneAsync("MenuScene");
            }
        } else
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                DeactivateCoachMode();
            }
        }
    }

    public void ActivateCoachMode()
    {
        if (!gameManager.CoachMode)
        {
            gameManager.CoachMode = true;
            cameras[activeCamIndex].enabled = false;
            coachModeCamera.enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        { 
            DeactivateCoachMode();
        }
    }

    public void DeactivateCoachMode()
    {
        gameManager.CoachMode = false;
        cameras[activeCamIndex].enabled = true;
        coachModeCamera.enabled = false;
        Cursor.lockState = CursorLockMode.None;
    }
    
}
