using UnityEngine;
using UnityEngine.UI;

public class SmashSingleton : MonoBehaviour
{
    public static SmashSingleton instance = null;

    private Transform target;

    private void Awake()
    {
        if(instance == null || instance != this)
        {
            instance = this;
        }
    }
    private void Start()
    {
        
    }
}