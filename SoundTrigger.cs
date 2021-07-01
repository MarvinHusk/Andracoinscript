using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    public AudioClip sonidito;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Player){
            AudioSource.PlayClipAtPoint(sonidito, this.gameObject.transform.position);
            
        }
    }
}
