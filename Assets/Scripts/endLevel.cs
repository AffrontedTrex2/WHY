using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class endLevel : MonoBehaviour {

    public GlobalControl global;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Teleports the player to a new scene depending on which level they're currently on
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            global.saveGems();
            Debug.Log(global.gems);
            if (SceneManager.GetActiveScene().name == "Level1")
                SceneManager.LoadScene("Level 2");
            if (SceneManager.GetActiveScene().name == "Level 2")
                SceneManager.LoadScene("Dialogue3");
            if (SceneManager.GetActiveScene().name == "Level 3")
                SceneManager.LoadScene("Dialogue5");
        }
    }
}
