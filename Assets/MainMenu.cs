using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play11()
    {
        SceneManager.LoadScene("Car1 Game1");
    }
     public void Play12()
    {
        print("deneme");
        SceneManager.LoadScene("Car1Game2");
    }
      public void Play21()
    {
        SceneManager.LoadScene("Car2Game1");
    }   
    
        public void Play()
    {
        SceneManager.LoadScene("Map");
    }
      public void Play22()
    {
        SceneManager.LoadScene("Car2 Game2");
    }
}
