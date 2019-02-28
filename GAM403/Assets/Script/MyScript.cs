using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{// Pay Attention in class you stupid c***

    public int ammo = 999999999;
    public int heath = 100;
    public float accuracy = 15.5f;
    public float playerSpeed = 0.5f;
    public float speedBurst = -0.01f;
    public string player = "Luke";

    public Vector3 starting;

    // Start is called before the first frame update
    void Start()
    {
        ammo = ammo + ammo;
        Debug.Log("My Ammo is: " + ammo);
        transform.position = starting;
    }

    // Update is called once per frame
    void Update()
    {
        playerSpeed = playerSpeed + speedBurst; // Increases our player speed
        transform.Translate(Vector3.forward * playerSpeed); //Moves us forward in the game test mode
    }
}
