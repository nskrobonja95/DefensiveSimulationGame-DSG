using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Custom.UI
{
    class DragUIElement : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {

        Vector2 clickPosition;
        Vector2 currentPosition;

        Vector2 startPoint;

        Vector2 lowerLeftBoundary;
        Vector2 upperRightBoundary;

        Vector3[] boundaries;

        Vector2 endPoint;
        bool drag;
        RectTransform DragImage;

        RectTransform parent;

        GameObject parentGameObject;

        public Camera SceneCamera;

        private void Start()
        {
            Debug.Log("Let me know");
            parent = GetComponentInParent<RectTransform>();
            parentGameObject = GameObject.Find("FormationPanel");
            RectTransform temp = parentGameObject.GetComponent<RectTransform>();
            boundaries = new Vector3[4];
            temp.GetWorldCorners(boundaries);
            upperRightBoundary = parent.rect.max;
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            startPoint = eventData.position;
            clickPosition = eventData.position;
            startPoint = eventData.position;
            endPoint = eventData.position;
        }

        public void OnDrag(PointerEventData eventData)
        {
            endPoint = SceneCamera.ScreenToWorldPoint(Input.mousePosition);
            if (boundaries[0].x >= endPoint.x || boundaries[0].y >= endPoint.y)
                return;
            if (boundaries[1].x >= endPoint.x || boundaries[1].y <= endPoint.y)
                return;
            if (boundaries[2].x <= endPoint.x || boundaries[2].y <= endPoint.y)
                return;
            if (boundaries[3].x <= endPoint.x || boundaries[3].y >= endPoint.y)
                return;
            Image img = gameObject.GetComponent<Image>();
            if (img != null)
                img.color = Color.red;
            transform.position = endPoint;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            Image img = gameObject.GetComponent<Image>();
            if(img != null)
                img.color = Color.white;
            if (boundaries[0].x <= endPoint.x || boundaries[0].y <= endPoint.y)
                return;
            if (boundaries[1].x <= endPoint.x || boundaries[1].y >= endPoint.y)
                return;
            if (boundaries[2].x >= endPoint.x || boundaries[2].y >= endPoint.y)
                return;
            if (boundaries[3].x >= endPoint.x || boundaries[3].y <= endPoint.y)
                return;            
            transform.position = endPoint;
        }

    }
}
