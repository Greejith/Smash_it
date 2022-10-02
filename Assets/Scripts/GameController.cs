using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject[] Virus;
    private int loop;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCube", 0f, 10f);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnCube()
    {
        loop = 15;
        for (int i = 0; i <= loop; i++)
        {
            int rand = Random.Range(0, Virus.Length);
            Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F), Random.Range(-10.0F, 10.0F),0).normalized* Random.Range(5, 10);
           
            Instantiate(Virus[rand], position, Quaternion.identity);
        }
        loop = 0;
    }
}
