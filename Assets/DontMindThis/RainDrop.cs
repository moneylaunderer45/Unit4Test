using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainDrop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.right * Random.Range(-3.0f,3.0f));
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * Random.Range(-3.0f, 3.0f));
        Invoke("DelayedDestroy", 3);  
    }

    public void DelayedDestroy()
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
