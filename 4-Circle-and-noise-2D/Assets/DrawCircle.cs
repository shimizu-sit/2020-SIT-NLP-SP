using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCircle : MonoBehaviour
{
    public float ThetaScale = 0.01f;
    public float radius = 3f;
    private int Size;
    private LineRenderer lr;
    private float Theta = 0f;
    Color LineColor = new Color(0.08f, 0.02f, 0.27f, 0.3f);

    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        lr.material = new Material(Shader.Find("Sprites/Default"));
        lr.startColor = LineColor;
        lr.endColor = LineColor;
        lr.startWidth = 0.1f;
        lr.endWidth = 0.1f;

        Theta = 0f;
        Size = (int)((1f / ThetaScale) + 1f);
        lr.positionCount = Size;
        for(int i = 0; i < Size; i++)
        {
            Theta += (2.0f * Mathf.PI * ThetaScale);
            float x = radius * Mathf.Cos(Theta);
            float y = radius * Mathf.Sin(Theta);
            lr.SetPosition(i, new Vector3(x, y, 0));
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
