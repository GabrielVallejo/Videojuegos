using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Personaje : MonoBehaviour
{
    private Rigidbody rb;
    public Text Score;
    private float puntaje = 100;

    // Start is called before the first frame update
    void Start()
    {
        this.Score.text = puntaje.ToString("R");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        transform.Translate(5 * h * Time.deltaTime, 0, 5*Time.deltaTime, Space.World);
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector3(0, 6.5f, 0), ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name!="Suelo") {
            this.puntaje -= 10;
            this.Score.text = this.puntaje.ToString("R");
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        this.puntaje += 100;
        this.Score.text = this.puntaje.ToString("R");
        transform.Translate(0, 0, -91, Space.World);
    }


}
