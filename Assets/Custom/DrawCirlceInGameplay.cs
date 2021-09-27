using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCirlceInGameplay : MonoBehaviour
{
    LineRenderer line;

    public float Radius = 20.0f;
    int Size;
    float Angle = 0.0f;
    float Scale = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
        Size = (int)(1 / Scale + 1.0f);
        line.positionCount = Size + 1;
        for (int i = 0; i <= Size; ++i)
        {

            float x = Radius * Mathf.Cos(Angle);
            float z = Radius * Mathf.Sin(Angle);
            //points[i] = new Vector3(x, y, gameObject.transform.position.z);
            line.SetPosition(i, new Vector3(x, 0.1f, z));
            Angle += 2 * Mathf.PI / Size;
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*Size = (int)(1 / Scale + 1.0f);
        line.positionCount = Size + 1;
        for (int i = 0; i <= Size; ++i)
        {

            float x = Radius * Mathf.Cos(Angle);
            float z = Radius * Mathf.Sin(Angle);
            //points[i] = new Vector3(x, y, gameObject.transform.position.z);
            line.SetPosition(i, new Vector3(x, 0.1f, z));
            Angle += 2 * Mathf.PI / Size;
        }*/

    }
}
