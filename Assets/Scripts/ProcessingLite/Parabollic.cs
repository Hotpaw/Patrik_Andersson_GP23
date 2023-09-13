using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parabollic : ProcessingLite.GP21
{
    int modulus = 0;
	public float numberOfLines = 20;

    // Start is called before the first frame update
    void Start()
    {
		//Reduce framerate so we can see the animation
        Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    void Update()
    {
		//Clear our background (Processeing Lite function)
		Background(0);

		//Manual approach to the problem
		//We can now see a clear pattern.

		//Line(0, 10, 1, 0);
		//Line(0, 9, 2, 0);
		//Line(0, 8, 3, 0);
		//Line(0, 7, 4, 0);
		//Line(0, 6, 5, 0);
		//Line(0, 5, 6, 0);


		//Loop approach to our solution
		//Still a static solution that only does 10 lines

		//for (int i = 0; i < 10; i++)
		//{
		//	if (i % 3 == modulus)
		//	{
		//		Stroke(128);
		//	}
		//	else
		//	{
		//		Stroke(255);
		//	}

		//	Line(0, 10 - i, 1 + i, 0);
		//}

		//Calculate distance between lines based on number of lines and camera size.
		float distanceBetweenLinesY = Height / numberOfLines;
		float distanceBetweenLinesX = Width / numberOfLines;

		for (int i = 0; i < numberOfLines; i++)
		{
			if (i % 3 == modulus)
			{
				Stroke(128);
			}
			else
			{
				Stroke(255);
			}

			//Different print based on our calucated values
			Line(0, Height - i * distanceBetweenLinesY, i * distanceBetweenLinesX, 0);
		}

		//change value for our modulus check to create a animation.
		modulus++;
        modulus = modulus % 3;
	}
}
