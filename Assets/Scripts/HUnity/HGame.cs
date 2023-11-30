using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DesignTable.Core;

public class HGame : MonoBehaviour
{
    // static
    private static HGame _instance;
    public static HGame Instance
    {
        get
        {
            if (null == _instance)
            {
                _instance = Object.FindFirstObjectByType<HGame>();
                if (null == _instance)
                {
                    var go = new GameObject("GameInstance");
                    _instance = go.AddComponent<HGame>();
                }
            }
            return _instance;
        }
    }
    
    // non-static
    public DContext D { get; private set; }
    
    private void Awake()
    {
        if (null != _instance && this != _instance)
        {
            Destroy(gameObject);
        }

        _instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
    void Start()
    {
        Debug.Log("start game instance");

        D = new DContext("Assets/Resources/DesignDatas/");
        D.Initialize();
    }

    void Update()
    {
    }
}
