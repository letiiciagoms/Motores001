using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{
    public Transform alvo;
    public Vector3 offset;
    public float sensib = 2;
    private float vaw
    // Start is called before the first frame update
    void Start()
    {
        offset = alvo.position - transform.position;
        alvo = GameObject.FindObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = alvo.position - offset;
        
    }
}
