using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusMovement : MonoBehaviour
{
    private Transform target;
    public float moveSpeed;
    public enum Virustype { x1, x2};

    private void Start()
    {
        if (GameObject.FindWithTag("Player"))
            target = GameObject.FindWithTag("Player").transform;


        
    }
    private void Update()
    {
        switch case
        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Camera.main.GetComponent<CameraShake>().shakeDuration = 1f;
            UIManager.instance.ShowBloodEffect();
            Destroy(this.gameObject);
            
        }
    }


}
