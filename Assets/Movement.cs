using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool goingLeft;
    
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 10)
            goingLeft = true;

        if (transform.position.x < 0)
            goingLeft = false;
   
        if (goingLeft)
            transform.Translate(new Vector3(Time.deltaTime * -speed, 0, 0));
        else 
            transform.Translate(new Vector3(Time.deltaTime * speed, 0, 0));
    }
}
