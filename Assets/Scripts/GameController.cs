using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance = null;
    public bool isgameover = false;

    public GameObject[] Virus;
    private int loop;
    
    // Start is called before the first frame update
    public void OnStart()
    {
        InvokeRepeating("SpawnCube", 0f, 10f);
        

    }
    private void Awake()
    {
        if (instance == null || instance != this)
        {
            instance = this;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnCube()
    {
        if (!isgameover)
        {
            loop = 13;
            for (int i = 0; i <= loop; i++)
            {
                int rand = Random.Range(0, Virus.Length);
                Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F), Random.Range(-10.0F, 10.0F), 0).normalized * Random.Range(5, 10);
                GameObject virus = Instantiate(Virus[rand], position, Quaternion.identity);
                virus.transform.parent = this.transform;
            }

            loop = 0;
        }
    }
}
