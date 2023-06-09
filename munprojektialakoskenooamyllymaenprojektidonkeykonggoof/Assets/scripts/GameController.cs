using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    
    void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Lose()
    {
        Debug.Log("Lose");
        ResetScene();
    }
     public void Win()
    {
        Debug.Log("Win");
        ResetScene();
    }
   
   
}
