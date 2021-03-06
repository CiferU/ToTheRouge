using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player")) 
        {
            Debug.Log("You died");
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
        }
    }

}
