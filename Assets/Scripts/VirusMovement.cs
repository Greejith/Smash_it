using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusMovement : MonoBehaviour
{
    private Transform target;
    public float moveSpeed;
    public enum Virustype { x1, x2}
    public Virustype virustype;
    
    private void Start()
    {
        if (GameObject.FindWithTag("Player"))
            target = GameObject.FindWithTag("Player").transform;

       
        
    }
    private void Update()
    {
        switch(virustype)
        {
            case Virustype.x1:
                transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
                break;
            case Virustype.x2:
                transform.RotateAround(target.transform.position, Vector3.back, 20 * Time.deltaTime);
                transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
                break;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Camera.main.GetComponent<CameraShake>().shakeDuration = 1f;
            UIManager.instance.ShowBloodEffect();
            UIManager.instance.live = UIManager.instance.live - 1;
            if(UIManager.instance.live <0)
            {
                UIManager.instance.live = 0;
            }
            UIManager.instance.ReduceHealth();
            Destroy(this.gameObject);
            
        }
    }


}
