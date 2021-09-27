using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCircle : MonoBehaviour
{
    LineRenderer line;

    public float Radius = 15.0f;
    public float centerTranslation = 195.0f;
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
            float y = Radius * Mathf.Sin(Angle);
            //points[i] = new Vector3(x, y, gameObject.transform.position.z);
            line.SetPosition(i, new Vector3(x + centerTranslation, y, gameObject.transform.position.z));
            Angle += 2 * Mathf.PI / Size;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        //line.SetPositions(points);
    }
}
