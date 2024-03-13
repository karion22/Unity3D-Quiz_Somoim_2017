using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{
    public GameObject _menu;
    public GameObject[] _items;

    public override void Start()
    {
        base.Start();
        Return();
    }

    public void Select(int index)
    {
        _menu.SetActive(false);
        for (int i = 0; i < _items.Length; i++)
        {
            _items[i].SetActive(i == index);
        }
    }

    public void Return()
    {
        _menu.SetActive(true);
        for (int i = 0; i < _items.Length; i++)
        {
            _items[i].SetActive(false);
        }
    }
}

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    private static T _instance = null;

    public static bool IsInstantiate { get { return _instance != null; } }

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<T>() as T;
                if (_instance == null)
                    _instance = new GameObject(typeof(T).ToString(), typeof(T)).GetComponent<T>();
                else
                    CreateInstance(_instance);
            }

            return _instance;
        }
    }

    private static void CreateInstance(Object inTarget)
    {
        _instance = inTarget as T;
        if (_instance != null)
        {
            _instance.Start();
        }
    }

    private void Awake()
    {
        CreateInstance(this);
    }

    public virtual void Start()
    {
        DontDestroyOnLoad(_instance);
    }

    public void OnDestroy()
    {
        _instance = null;
    }

    public void OnApplicationQuit()
    {
        OnDestroy();
    }
}
