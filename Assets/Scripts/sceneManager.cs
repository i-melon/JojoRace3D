using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{   
    public void nextLevel(int _sceneNumber){
        SceneManager.LoadScene(_sceneNumber);
    }
}
