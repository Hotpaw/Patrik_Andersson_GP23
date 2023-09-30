using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public List<AudioSource> sources;
    public AudioSource currentSound;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlaySound(string name)
    {
        currentSound = GetComponent<AudioSource>();
        switch(name)
        {
            case "Laser":
                currentSound.clip = sources[0].clip;
                break;
            case "Explosion":
                currentSound.clip = sources[1].clip;
                break;
        }
        currentSound.pitch = Random.Range(0.5f, 1.0f);
        currentSound.volume = 0.5f;
        currentSound.PlayOneShot(currentSound.clip);
    }
}
