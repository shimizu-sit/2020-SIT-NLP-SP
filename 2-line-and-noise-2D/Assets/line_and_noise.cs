using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line_and_noise : MonoBehaviour
{
    public int numCapVertices = 10;
    public int numCornerVertices = 10;
    private LineRenderer lr;
    Color lineColor = new Color(0.08f, 0.2f, 0.27f, 0.3f);

    // Start is called before the first frame update
    void Start()
    {
        float step = 0.5f;
        int index = 0;

        lr = GetComponent<LineRenderer>();
        lr.material = new Material(Shader.Find("Sprites/Default"));
        lr.startColor = lineColor;
        lr.endColor = lineColor;
        lr.startWidth = 0.1f;
        lr.endWidth = 0.1f;
        lr.positionCount = 41;
        lr.numCapVertices = numCapVertices;
        lr.numCornerVertices = numCornerVertices;

        for (float x = -10.0f; x <= 10.0f; x += step)
        {
            float yRange = Random.Range(-4.0f, 4.0f);
            float y = Random.Range(-1.0f*yRange, yRange);
            lr.SetPosition(index, new Vector3(x, y, 0));
            Debug.Log(y);
            index++;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

}
