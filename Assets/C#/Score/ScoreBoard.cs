using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    public GameObject BGM_Game;
    public GameObject data;
    public Data dataCs;
    public Text message;

    void Start()
    {
        BGM_Game = GameObject.FindWithTag("BGM_Game");
        Destroy(BGM_Game);
        data = GameObject.Find("Data");
        if(data == null)
        {
            message.text = "0.00";
        }
        else
        {
            dataCs = data.GetComponent<Data>();
            message.text = dataCs.score.ToString("f2");
        }
    }
}