using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioClip clicksound;
    private int count=0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Collectible"))
        {
            count++;
            AudioSource.PlayClipAtPoint(clicksound,other.transform.position);
            Destroy(other.gameObject);
        }
    
    }
}
