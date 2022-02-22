using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterTheTrain : MonoBehaviour
{
    public GameObject Player;
    private int nextScene;
    private void Start()
    {
        if (Player == null)
            Player = GameObject.FindGameObjectWithTag("Player");
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(nextScene);
    }
}
