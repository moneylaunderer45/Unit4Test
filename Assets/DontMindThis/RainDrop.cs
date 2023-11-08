using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainDrop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DelayedDestroy", 1);  
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
