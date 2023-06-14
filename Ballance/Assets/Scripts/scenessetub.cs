using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenessetub : MonoBehaviour
{
    // Start is called before the first frame update
    public void Scenes(int numberscenes)
    {
        SceneManager.LoadScene(numberscenes);
    }

    public void Quitgame()
    {
        Console.WriteLine("quit");
        Application.Quit();
    }


    // Update is called once per frame

}
