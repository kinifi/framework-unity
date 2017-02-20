/*
 *  Game Manager
 *  Use variables and methods between scenes here
 *
 */

/// Note: that the more namespaces we use the more loading this screen has to do
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;

public class GameManager
{

	//Class Level Members Start


	//Class Level Members End


	//Method Start

    /// <summary>
    /// load all of the data on setup
    /// This should be called on the title screen
    /// </summary>
    public void Setup()
    {



    }


	//Method End

	//create a local instance of GameManager
    private static GameManager instance;

    //If there isn't a GameManager instance, create one.
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager();
            }
            return instance;
        }
    }
	
    private void Shutdown()
    {
        if (instance != null) {
            instance = null;
        }	
    
    }

}
