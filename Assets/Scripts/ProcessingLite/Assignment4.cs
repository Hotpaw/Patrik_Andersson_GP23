using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment4 : ProcessingLite.GP21
{
    Vector2 circlePosition;
    Vector2 circleVelocity;
    float maxSpeed = 0.25f;

    // Start is called before the first frame update
    void Start()
    {
        circlePosition = new Vector2(Width / 2, Height / 2);
    }

    // Update is called once per frame
    void Update()
    {
        Background(128);

        if(Input.GetMouseButtonDown(0))
        {
            circlePosition.x = MouseX;
            circlePosition.y = MouseY;
            circleVelocity = Vector2.zero;
        }
        if(Input.GetMouseButton(0)) 
        { 
            Line(circlePosition.x, circlePosition.y, MouseX, MouseY);
        }
		if (Input.GetMouseButtonUp(0))
        {
            circleVelocity = (new Vector2(MouseX, MouseY) - circlePosition) * 0.01f;

            if (circleVelocity.magnitude > maxSpeed)
            {
                circleVelocity.Normalize();
                circleVelocity *= maxSpeed;
            }
        }

        if (circlePosition.x > Width || circlePosition.x < 0)
        {
            circleVelocity.x *= -1;
		}
		if (circlePosition.y > Height || circlePosition.y < 0)
		{
			circleVelocity.y *= -1;
		}

		circlePosition += circleVelocity;

		Circle(circlePosition.x, circlePosition.y, 1);
    }
}
