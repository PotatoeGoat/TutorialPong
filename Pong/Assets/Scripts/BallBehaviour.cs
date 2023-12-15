using System.Collections;
using System.Collections.Generic;


using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField]
    private Vector3 direction;


    // Start is called before the first frame update
    void Start()
    {
        if(Random.Range(0.0f,1.0f)<0.5f)
        {
            
            direction = Vector3.right;
        }
        else
        {
            
            direction = Vector3.left;
        }

        if (Random.Range(0.0f, 1.0f) < 0.5f)
        {
            
            direction += Vector3.up;
        }
        else
        {
           
            direction += Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * 3 * Time.deltaTime;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("colision con " + collision.gameObject.name);

        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("cambiar direccion en eje x");
            direction.x = -direction.x;

            Debug.Log("cambiar direccion en eje y");
            //direction.y = -direction.y;
        }

        if (collision.gameObject.CompareTag("Border"))
        {
            Debug.Log("cambiar direccion en eje x");
            //direction.x = -direction.x;

            Debug.Log("cambiar direccion en eje y");
            //direction.y = Random.Range()
        }
    }

}
