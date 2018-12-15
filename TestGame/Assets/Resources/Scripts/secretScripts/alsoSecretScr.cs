using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alsoSecretScr : ScriptableObject{

    GameObject[] mySecretBots;

    public void Init(int _teamNumber, int _botCount, GameObject _botType)
    {
        mySecretBots = new GameObject[_botCount];

        int i = 0;
        foreach (GameObject _bot in mySecretBots)
        {
            mySecretBots[i] = Instantiate(_botType, new Vector3(0, 0, 0), Quaternion.identity);
            mySecretBots[i].GetComponent<topSecretScr>().Init();
            i++;
        }
    }
}
