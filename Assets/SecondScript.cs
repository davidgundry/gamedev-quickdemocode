using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Movement))]
[RequireComponent(typeof(Rigidbody))]
public class SecondScript : MonoBehaviour
{
    private Movement movement;
    // Start is called before the first frame update

    void Start()
    {
        movement = gameObject.GetComponent<Movement>();
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(new Vector3(0,Time.deltaTime*20, 0));

        if (Input.GetKeyDown(KeyCode.A))
            movement.speed += 10;

    }
}
