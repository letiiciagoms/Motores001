using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int velocidade = 10;
    public int forcaPulo = 7;
    private Rigidbody rb;

    public bool noChao;


    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent (out rb);
    }

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "Chão")
        {
            noChao = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 direção = new Vector3(h, 0, v);
        rb.AddForce(direcao * Time.deltaTime, ForceMode.Impulse);

        if (Input.GetKeyDown(KeyCode.Space) && noChao)
        {
            rb.AddForce(Vector3.up * forcaPulo, FoceMode.Impulse);
            noChao = false;
        }

        if (tranform.position.y <= -10)
        {
            SceneManagement.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }
}
