using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalinput;
    public float speed;
    public float Bounds;
    // movement floats

    public Transform PlayerBlaster;
    public GameObject LaserBlast;
    // laser blasters
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * horizontalinput * Time.deltaTime * speed);
        //moves player left to right
        if (transform.position.x < -Bounds)
        {
            transform.position = new Vector3(-Bounds, transform.position.y, transform.position.z);
        }
        if (transform.position.x > Bounds)
        {
            transform.position = new Vector3(Bounds, transform.position.y, transform.position.z);
        }
        //keeps player inside playing field
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(LaserBlast, PlayerBlaster.transform.position, LaserBlast.transform.rotation);
            //creates laser blast at the blaster position and rotation
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
