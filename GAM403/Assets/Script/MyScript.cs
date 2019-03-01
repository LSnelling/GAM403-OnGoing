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
    public int healthbonus = 6;

    public Vector3 starting;

    // Start is called before the first frame update
    void Start()
    {
      
       
        
    }

    // Update is called once per frame
    void Update()
    {
        //playerSpeed = playerSpeed + speedBurst; // Increases our player speed
        //transform.Translate(Vector3.forward * playerSpeed); //Moves us forward in the game test mode
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * playerSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * playerSpeed);
        }
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(h, 0, v));
    }
    void AddToHealth(int heathmodifier)
    {
        heath += healthbonus;
    }
}
