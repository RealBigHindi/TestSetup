using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secretScr : MonoBehaviour {

    //Images
    public Texture2D secretArenaImage;
    public Texture2D secretArenaPthfImage;

    //Prefabs
    public GameObject specOpsBotPref;

    //GameObjects
        //BotTeams
        public alsoSecretScr[] secretBotTeams;

    //ArenaData
        public secretArenaScr secretArena;

    //Settings
    int botsPerTeam = 1;
    int teamCount = 2;

	// Use this for initialization
	void Start () {
        secretArena = ScriptableObject.CreateInstance<secretArenaScr>();
        secretArena.Init(secretArenaImage, secretArenaPthfImage);

        secretBotTeams = new alsoSecretScr[teamCount * botsPerTeam];

        int i = 0;
		foreach (alsoSecretScr _botTeam in secretBotTeams)
        {
            secretBotTeams[i] = ScriptableObject.CreateInstance<alsoSecretScr>();
            secretBotTeams[i].Init(i, botsPerTeam, specOpsBotPref);
            i++;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
