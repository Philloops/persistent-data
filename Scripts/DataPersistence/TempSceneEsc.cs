using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TempSceneEsc : MonoBehaviour
{//this class is just temporary behaviour, in reality this saving would execute somewhere before a scene transition
    private bool queued = false;

    void Update()
    {
        if (queued)
            return;

        // below code just used to test exiting the scene,
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            queued = true;
            // save the game anytime before loading a new scene
            DataPersistenceManager.instance.SaveGame();
            // load the main menu scene
            SceneManager.LoadSceneAsync("MainMenu");        
        }
    }
}
