using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public Vector3 rotate;
    public float speed;
    float random;
   
    public Vector2 MoveVector;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(-10, 10);
        random = Random.Range(-2, 2);
        MoveVector = new Vector2(random,random);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,random / 10);
        transform.position += new Vector3(0.1f, 0.1f) * speed *Time.deltaTime;
    }
}
