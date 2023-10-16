using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour
{
    public int velocidadedeGiro = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(gameObject);        
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, velocidadedeGiro * Time.deltaTime);
        
    }
}
