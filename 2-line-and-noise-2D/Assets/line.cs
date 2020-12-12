using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour
{
    Color lineColor = new Color(0.0f, 0.0f, 0.0f, 0.11f);

    // Start is called before the first frame update
    void Start()
    {
        LineRenderer lr = gameObject.GetComponent<LineRenderer>();
        lr.material = new Material(Shader.Find("Sprites/Default"));
        lr.startColor = lineColor;
        lr.endColor = lineColor;
        lr.startWidth = 0.1f;
        lr.endWidth = 0.1f;
        lr.positionCount = 2;

        lr.SetPosition(0, new Vector3(-10f, 0f, 0f));
        lr.SetPosition(1, new Vector3(10f, 0f, 0f));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
