using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : ProcessingLite.GP21
{
    Vector2 circlePosition = new Vector2(10, 27);
    float dimention = 5;

    List<int> points = new();

    // Start is called before the first frame update
    void Start()
    {
		points = new List<int>();
		points.Add(1000);
	}

    // Update is called once per frame
    void Update()
    {
        Circle(circlePosition.x, circlePosition.y, dimention);
    }
}
