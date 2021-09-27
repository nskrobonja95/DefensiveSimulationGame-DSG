using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawFilledCircle : MonoBehaviour
{

    LineRenderer line;

    float Radius = 2.0f;
    int Size;
    float Angle = 0.0f;
    float Scale = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
        Size = (int)(1 / Scale + 1.0f);
        line.positionCount = 2*Size + 1;
        Vector3 centerPos = new Vector3(0f, gameObject.transform.position.y, 0.0f);
        for (int i = 0; i <= 2*Size-1; i+=2)
        {

            float x = Radius * Mathf.Cos(Angle);
            float z = Radius * Mathf.Sin(Angle);
            //points[i] = new Vector3(x, y, gameObject.transform.position.z);
            line.SetPosition(i, centerPos);
            line.SetPosition(i+1, new Vector3(x, gameObject.transform.position.y, z));
            Angle += 2 * Mathf.PI / Size;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
