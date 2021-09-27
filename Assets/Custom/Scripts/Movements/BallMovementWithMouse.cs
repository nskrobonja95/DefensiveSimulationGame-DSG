using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts.Movements
{
    class BallMovementWithMouse : MonoBehaviour
    {
        GameObject ballObj;

        private void Start()
        {
            ballObj = GameObject.Find("BallObj");
        }

        private void OnMouseDrag()
        {
            Camera activeCam = GetActiveCamera();
            Vector3 ballDistanceInScreenCoord = activeCam.
                WorldToScreenPoint(ballObj.transform.position);
            float distance_to_screen = ballDistanceInScreenCoord.z;
            Vector3 pos_move = activeCam.
                ScreenToWorldPoint(new Vector3(
                    Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
            ballObj.transform.position = 
                new Vector3(pos_move.x, ballObj.transform.position.y, pos_move.z);
        }

        private Camera GetActiveCamera()
        {
            GameObject cameras = GameObject.Find("Cameras");
            Component[] sceneCameras = cameras.GetComponentsInChildren(typeof(Camera));
            for(int i=0; i<sceneCameras.Length; ++i)
            {
                if ( ((Camera)sceneCameras[i]).enabled)
                    return (Camera) sceneCameras[i];
            }
            return null;
        }
    }
}
