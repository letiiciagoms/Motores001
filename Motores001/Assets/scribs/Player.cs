using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int velocidade = 10;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 direção = new Vector3(h, 0, v);
        rb.AddForce(direcao * Time.deltaTime, ForceMode.Impulse);

        if (tranform.position.y <= -10)
        {
            SceneManagement.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }
}
