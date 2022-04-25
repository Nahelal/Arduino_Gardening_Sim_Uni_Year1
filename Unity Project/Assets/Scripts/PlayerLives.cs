using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLives : MonoBehaviour
{
    //array of player lives
    public GameObject[] heartModel;
    private int lives = 3;

    // Start is called before the first frame update
    void Start()
    {
        lives = heartModel.Length;

    }

    // Update is called once per frame
    void Update()
    { }


    public void wrongInput()
    {
        if (lives >= 1)
        {
            //heart is removed from UI and player life -1
            lives -= 1;
            Destroy(heartModel[lives].gameObject);

            if (lives == 0)
            {
                //if player loses all 3 lives, they go back to the menu screen
                Debug.Log("game overrrr :D ");
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
