using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeTest : ProcessingLite.GP21
{
    Vector2 pos;
    Vector2 vel;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Background(0);

        if (Input.GetMouseButtonDown(0))
        { 
            pos = new Vector2(MouseX, MouseY);
            vel = Vector2.zero;
        }

		if (Input.GetMouseButton(0))
		{
            Line(pos.x, pos.y, MouseX, MouseY);
		}

		if (Input.GetMouseButtonUp(0))
		{
            vel = (new Vector2(MouseX, MouseY) - pos) * 0.01f;
		}

        pos += vel;

        if (pos.x < 0 || pos.x > Width)
        {
            vel.x *= -1;
        }
		
        if (pos.y < 0 || pos.y > Height)
		{
			vel.y *= -1;
		}

		Circle(pos.x, pos.y, 1);
    }
}
