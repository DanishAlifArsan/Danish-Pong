using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
 
public class MainMenuController : MonoBehaviour 
{ 
    public void PlayGame() 
    { 
        Debug.Log("Created by Danish");
        SceneManager.LoadScene("SampleScene"); 
    } 
    public void BackToMenu() 
    { 
        SceneManager.LoadScene("Main Menu"); 
    } 
    public void Credit() 
    { 
        SceneManager.LoadScene("Credit"); 
    } 
} 
