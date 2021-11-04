using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyWin : MonoBehaviour
{
    public Transform spawn;
    public Transform player;
    public Transform spawn_enemy;
    public Transform enemy;
    public AudioSource warning;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.position = spawn.position;
            enemy.position = spawn_enemy.position;
            warning.Play();
        }
    }
}
