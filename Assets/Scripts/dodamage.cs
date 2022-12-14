using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dodamage : MonoBehaviour
{
    public float timeToRevivePlayer;
    private float timeRevivalCounter;
    private bool isPlayerReviving;
    private GameObject player;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name.Equals("player"))
        {
            player = other.gameObject;
            player.SetActive(false);
            isPlayerReviving = true;
            timeRevivalCounter = timeToRevivePlayer;
        }
    }
    private void Update()
    {
        if (isPlayerReviving)
        {
            timeRevivalCounter -= Time.deltaTime;
            if (timeRevivalCounter <= 0)
            {
                isPlayerReviving = false;
                player.SetActive(true);
            }
        }
    }
}
