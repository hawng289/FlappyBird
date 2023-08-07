using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour

{
    GameObject bird;
    public float flyPower;
    private GameObject gameController;
    // Start is called before the first frame update

    void Start()
    {
        bird = gameObject;
        flyPower = 200;
        if (gameController == null)
        {
            gameController = GameObject.FindGameObjectWithTag("GameController");
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            bird.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyPower));

        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log(collision.gameObject.name);
        gameController.GetComponent<GameController>().EndGame();
    }

  
    
}
