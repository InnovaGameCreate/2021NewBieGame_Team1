using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    public GameObject data;
    public Data dataCs;
    public Text message;
    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.Find("Data");
        dataCs = data.GetComponent<Data>();
        message.text = dataCs.score.ToString("f2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
