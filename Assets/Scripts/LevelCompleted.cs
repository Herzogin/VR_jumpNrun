using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//from my repo: https://github.com/Herzogin/Island
public class LevelCompleted : MonoBehaviour
{
    public int SwitchToSceneNumber;
    string Scene;
    void Start()
    {
        if (SwitchToSceneNumber == 0)
        {
            Scene = "GameOver0";
        }
        else if (SwitchToSceneNumber == 1)
        {
            Scene = "RacetrackLevel1";
        }
        else if (SwitchToSceneNumber == 2)
        {
            Scene = "RacetrackLevel2";
        }
        else if (SwitchToSceneNumber == 3)
        {
            Scene = "RacetrackLevel3";
        }
        else if (SwitchToSceneNumber == 4)
        {
            Scene = "Won4";
        }
    }

    

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(Scene);
        //if (other.tag == "Player")
        //{
        //    SceneManager.LoadScene(Scene);
        //}
    }
}
