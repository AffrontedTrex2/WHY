using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class DeathTrigger : MonoBehaviour {

    public Health health;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("yes");
            health.ChangeHealth(-1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
