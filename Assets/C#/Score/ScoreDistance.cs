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
    // Start is called before the first frame update
    void Start()
    {
        Enemy = GameObject.Find("Enemy");//HOIで吹き飛ばされるオブジェクトの名前を書いてください。名前が分からないので今はとりあえずcubeにしています。
       data = GameObject.Find("Data");
        dataCs = data.GetComponent<Data>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos1 = Enemy.transform.position;//cubeのところに吹き飛ばされるオブジェクトの名前を書いてください。
		Vector3 pos2 = new Vector3(0.00f, 0.50f, 0.00f);
       
        float dis = Vector3.Distance(pos1,pos2);//原点とオブジェクト間の距離を測定。
        MajorText.text = "現在の距離: " + dis.ToString("f2")+ "m";
        dataCs.score = dis;
    }
}
