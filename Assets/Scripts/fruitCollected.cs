using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitCollected : MonoBehaviour
{
    public AudioSource playSound;
    public AudioClip clip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            AudioSource.PlayClipAtPoint(clip,new Vector2(5,1));
                Destroy(gameObject, 0.5f);
                Debug.Log(playSound.time);
        }
    }
}
