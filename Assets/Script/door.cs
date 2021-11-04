using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public Animator open;
    private bool _open;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (other.GetComponent<KeyOpen>().KeyHas = true)
            {
                open.SetBool("isOpened", _open);
                _open = !_open;
            }
        }
    }
}
