using System.Collections;
using UnityEngine.Networking;
using System.Collections.Generic;
using UnityEngine;

public class SpikeHead : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("GameOver");
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
            int dead = 1;

            String formData = 
            formData.Add(dead);

            UnityWebRequest www = UnityWebRequest.Post("http://localhost:4000/tries", formData);
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Form upload complete!");
            }
        }
    }
}
