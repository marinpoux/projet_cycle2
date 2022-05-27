using System;
using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    public static event Action GameOver;

    private GameObject player;
    private Component gameOverCollider;

    private void Awake()
    {
        GameOver += PrintConsole;   // sub the methode to the event
    }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        if (gameObject.GetComponent<Collider>())
            gameObject.GetComponent<Collider>().isTrigger = true;
        if (gameObject.GetComponent<Collider2D>())
            gameObject.GetComponent<Collider2D>()!.isTrigger = true;
    }

    // physical game over trigger -> apply on either 2d or 3d trigger collider

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
            GameOver?.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
            GameOver?.Invoke();
    }

    private void PrintConsole()
    {
        Debug.Log("Game Over !!");
    }
}
