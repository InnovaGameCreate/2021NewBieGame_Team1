using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : GoPlay
{
    [SerializeField]
    GameObject BGM;

    public new void OnClickPlay()
    {
        Destroy(BGM);
    }
}
