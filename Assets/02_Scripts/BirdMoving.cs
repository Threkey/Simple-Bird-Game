using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMoving : MonoBehaviour
{
    public GameObject bird;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        //if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            bird.GetComponent<Rigidbody>().velocity = Vector3.up * force;
        }
    }
}
