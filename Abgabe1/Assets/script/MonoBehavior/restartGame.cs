﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartGame : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void restarting() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}