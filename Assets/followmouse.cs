using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followmouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var screenPoint = new Vector3(Input.mousePosition.x,Input.mousePosition.y,Input.mousePosition.z);
       
        transform.position = Camera.main.ScreenToWorldPoint(screenPoint);
    }
}
