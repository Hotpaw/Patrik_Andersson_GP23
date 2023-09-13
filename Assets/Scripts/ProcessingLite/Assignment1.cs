using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment1 : ProcessingLite.GP21
{
   

    public float y = 5;
    [Header("Hej")]
	public float diameter = 0.2f;

	float spaceBetweenLines = 0.2f;

	public int r, g, b;

	float frame;

	// Start is called before the first frame update
	void Start()
    {
		r = g = b = 128;

		Application.targetFrameRate = 10;
	}

	// Update is called once per frame
	void Update()
	{
		frame += 0.5f;

		if (frame % 5 == 5)
		{

		}

		Background(50, 166, 240);
		//Clear background

		StrokeWeight(1 + frame % 5);

		//Draw our art/stuff, or in this case a rectangle
		Stroke(255);

		Line(4, 7, 4, 3);
		Line(4, 5, 6, 5);
		Line(6, 7, 6, 3);

		Line(8, 5.5f, 8, 3);
		Line(8, 7, 8, 6.8f);

		//Prepare our stroke settings
		Stroke(r, g, b, 64);
		StrokeWeight(0.5f);

		//Draw our scan lines
		for (int i = 0; i < Height / spaceBetweenLines; i++)
		{
			//Increase y-cord each time loop run
			float y = i * spaceBetweenLines;

			//Draw a line from left side of screen to the right
			Line(0, y, Width, y);
		}

		for (int i = 0; i < 10; i++)
		{
			//Do stuff
		}
	}
}
