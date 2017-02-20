//
// Unity_Analytics_Singleton.cs provides easy static methods for use during game for analytics
//

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Analytics;

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
    
    #region Unity Analytics

    /// <summary>
    /// 
    /// </summary>
    /// <param name="EventName">Name of the Event. Example: "GameOver"</param>
    /// <param name="EventSubName">SubEventName. Such as Coins</param>
    /// <param name="EventValue">The value we need to pass with our event. Example: EventName - Death, SubEventName - Coins, EventValue - 100</param>
    public void Analytics_SingleEvent(string EventName, string SubEventName, string EventValue)
    {
        Analytics.CustomEvent(EventName, new Dictionary<string, object>
        {
            { SubEventName, EventValue }
        });
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="EventName">Name of the Event. Example: "GameOver"</param>
    /// <param name="EventSubName">SubEventName. Such as Coins</param>
    /// <param name="EventValue">A dictionary of Key-Pair values. Example: EventName: Death, Key in Dictionary: Coins, Value: 100</param>
    public void Analytics_SingleEvent(string EventName, Dictionary<string, object> EventValues)
    {
        Analytics.CustomEvent(EventName, EventValues);
    }

    #endregion

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
