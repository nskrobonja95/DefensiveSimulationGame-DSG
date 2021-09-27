using Assets.Custom.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuFootballField : MonoBehaviour
{

    private GameManager _gameManager;

    private RectTransform _rectTransform;

    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameManager.Instance;
        _rectTransform = GetComponent<RectTransform>();
        // _rectTransform.rect.width = _gameManager.FieldWidth / 3;
        //_rectTransform.sizeDelta = new Vector2(_gameManager.FieldWidth, _gameManager.FieldLength);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
