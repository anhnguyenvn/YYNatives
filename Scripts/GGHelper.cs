using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
using UnityEngine;
using System;

public class GGHelper : MonoBehaviour
{
    static GGHelper Instance;


    void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);

        InitGGService();
    }

    void InitGGService()
    {
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
        PlayGamesPlatform.InitializeInstance(config);
        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();
    }  
    
    public void Authenticate(SignInInteractivity signMode, Action cb)
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
