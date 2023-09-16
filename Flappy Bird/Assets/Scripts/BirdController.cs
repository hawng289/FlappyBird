using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour

{
    GameObject bird;
    private float flyPower;
    private GameObject gameController;
    public AudioClip flyClip;
    public AudioClip endGameClip;
    public AudioSource audioSource;
    // Start is called before the first frame update

    void Start()
    {
        bird = gameObject;
        flyPower = 200;
        audioSource = bird.GetComponent<AudioSource>();
        audioSource.clip = flyClip;
        if (gameController == null)
        {
            gameController = GameObject.FindGameObjectWithTag("GameController");
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !gameController.GetComponent<GameController>().isEnd())
        {
          
            audioSource.Play();
            bird.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyPower));

        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        audioSource.clip = endGameClip;
        audioSource.Play();
        gameController.GetComponent<GameController>().EndGame();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameController.GetComponent<GameController>().getPoint();
    }


}
