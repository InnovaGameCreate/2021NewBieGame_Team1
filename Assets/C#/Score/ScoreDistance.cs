using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreDistance : MonoBehaviour
{
    public GameObject Enemy;//HOIで吹き飛ばされるオブジェクトの名前を書いてください。名前が分からないので今はとりあえずcubeにしています。
    public Text MajorText;
    public GameObject data;
    public Data dataCs;
    Vector3 pos2;
    // Start is called before the first frame update
    void Start()
    {
        Enemy = GameObject.Find("Enemy");//HOIで吹き飛ばされるオブジェクトの名前を書いてください。名前が分からないので今はとりあえずcubeにしています。
       data = GameObject.Find("Data");
        dataCs = data.GetComponent<Data>();
        pos2 = Enemy.transform.position;
    }
    
    // Update is called once per frame
    void Update()
    {
        Vector3 pos1 = Enemy.transform.position;//cubeのところに吹き飛ばされるオブジェクトの名前を書いてください。
		
       
        float dis = Vector3.Distance(pos1,pos2) - 0.02f;//原点とオブジェクト間の距離を測定。
        MajorText.text = "ふっ飛ばした距離: " + dis.ToString("f2")+"m";
        dataCs.score = dis;
    }
}
