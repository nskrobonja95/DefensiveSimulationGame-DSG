using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineRendererUI : Graphic
{


    protected override void OnPopulateMesh(VertexHelper vh)
    {
        vh.Clear();

        RectTransform rectTransform = GetComponent<RectTransform>();

        var verts = new UIVertex[2];
        var inds = new int[6];

        UIVertex vert = UIVertex.simpleVert;
        vert.color = Color.white;        
        vert.position = new Vector2(0, 50);

        verts[0] = vert;

        vert.position = new Vector2(100, 50);

        verts[1] = vert;

        inds[0] = 0;
        inds[1] = 1;

        List<UIVertex> vertices = new List<UIVertex>();
        List< int > indices = new List<int>();

        vertices.AddRange(verts);
        indices.AddRange(inds);
        
        vh.AddUIVertexStream(vertices, indices);
    }

}
