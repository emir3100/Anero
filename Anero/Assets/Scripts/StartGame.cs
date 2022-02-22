using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject player;
    private void Start()
    {
        if(GameManager.Instance.GameStarted == false)
        {
            player.GetComponent<CharacterController2D>().enabled = false;
            player.GetComponent<PlayerMovement>().enabled = false;
            player.GetComponent<PlayerCombat>().enabled = false;
        }
        
    }



    public void PlayerStart()
    {
        GameManager.Instance.GameStarted = true;
        player.GetComponent<CharacterController2D>().enabled = true;
        player.GetComponent<PlayerMovement>().enabled = true;
        player.GetComponent<PlayerCombat>().enabled = true;
    }
}
