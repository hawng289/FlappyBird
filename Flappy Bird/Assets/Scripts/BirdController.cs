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
    private Animator anim;
    // Start is called before the first frame update

    void Start()
    {
        bird = gameObject;
        flyPower = 200;
        audioSource = bird.GetComponent<AudioSource>();
        audioSource.clip = flyClip;
        anim = bird.GetComponent<Animator>();
        anim.SetFloat("power", 0);
        anim.SetBool("isDead", false);
        if (gameController == null)
        {
            gameController = GameObject.FindGameObjectWithTag("GameController");
        }

    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("power", 0);
        if (Input.GetMouseButtonDown(0) && !gameController.GetComponent<GameController>().isEnd())
        {
            audioSource.Play();
            bird.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyPower));
            anim.SetFloat("power", 2);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        anim.SetBool("isDead", true);
        audioSource.clip = endGameClip;
        audioSource.Play();

        gameController.GetComponent<GameController>().EndGame();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameController.GetComponent<GameController>().getPoint();
    }


}
