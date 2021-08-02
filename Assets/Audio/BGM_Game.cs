using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM_Game : MonoBehaviour
{
    // GameControllerインスタンスの実体
    private static BGM_Game instance = null;

    // GameControllerインスタンスのプロパティーは、実体が存在しないとき（＝初回参照時）実体を探して登録する
    public static BGM_Game Instance => instance
        ?? (instance = GameObject.FindWithTag("BGM_Game").GetComponent<BGM_Game>());

    private void Awake()
    {
        // もしインスタンスが複数存在するなら、自らを破棄する
        if (this != Instance)
        {
            Destroy(this.gameObject);
            return;
        }

        // 唯一のインスタンスなら、シーン遷移しても残す
        DontDestroyOnLoad(this.gameObject);
    }

    private void OnDestroy()
    {
        // 破棄時に、登録した実体の解除を行う
        if (this == Instance) instance = null;
    }

    // あとはお好きなように
}
