using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fruitManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AllFruitsCollected();
    }
    public void AllFruitsCollected() 
    {
        if (transform.childCount == 0) 
        {
            Debug.Log("Todas las frutas han sido recolectadas");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
