using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundchang : MonoBehaviour
{
    public AudioSource current;

    public GameObject player;
    public AudioSource newsong;

    private void OnTriggerEnter(Collider other) {
       if(other.CompareTag("Player")){
           current.Stop();
           newsong.Play();
       }
    }
}
