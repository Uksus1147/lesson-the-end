using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winner : MonoBehaviour
{
    public AudioClip winnn;
    public AudioSource prog;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            prog.Play();
        }
    }
}
