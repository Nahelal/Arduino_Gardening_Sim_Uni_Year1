using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLives : MonoBehaviour
{
    //array of player lives
    public GameObject[] heartModel;
    private int lives = 3;
    private bool noLives;

    // Start is called before the first frame update
    void Start()
    {
        lives = heartModel.Length;

    }

    // Update is called once per frame
    void Update()
    {
        if (noLives = true)
        {
            //if player loses all 3 lives, they go back to the menu screen
            // SceneManager.LoadScene("Menu");
            Debug.Log("game overrrr :D ");
        }
    }

    public void wrongInput()
    {
        if (lives >= 1)
        {
            //
            lives -= 1;
            Destroy(heartModel[lives].gameObject);

            if (lives < 1)
            {
                noLives = true;
            }
        }
    }
}
