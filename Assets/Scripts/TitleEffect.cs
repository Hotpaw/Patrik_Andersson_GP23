using TMPro; //So we can use TextMeshPro stuff
using UnityEngine;
using UnityEngine.UI; //So we can use UI stuff

public class TitleEffect : MonoBehaviour
{
	public TextMeshProUGUI title; //Reference to our title
	public Image bgImage; //Background ref
	public Slider hpBar; //HP slider example ref
	public Image hpBarImage; //HP bar image example ref

	// Start is called before the first frame update
	void Start()
	{
		//Change the title text of our game
		title.text = "Super Awesome Game 2!";

		//Reset the value of our hp bars example
		hpBar.value = 1;
		hpBarImage.fillAmount = 1;
	}

	// Update is called once per frame
	void Update()
	{
		//Animate the title size using some math.
		title.fontSize = 35 + Mathf.Sin(Time.time * 10) * 25;

		//We also turned our title into a timer using this code:
		//title.text = Time.time.ToString();

		//remove HP from our health bars over time (-0.1f health / second)
		hpBar.value -= Time.deltaTime / 10; //Slider version
		hpBarImage.fillAmount -= Time.deltaTime / 10; //Image version
	}

	//We connected our playbutton to this script and toggled the background color.
	public void PlayButton()
	{
		//If background is red, change to white
		if (bgImage.color == Color.red)
		{
			bgImage.color = Color.white;
		}
		else
		{
			//background is not red, change to red.
			bgImage.color = Color.red;
		}
	}
}
