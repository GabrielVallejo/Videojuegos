using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo1 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed=0.5f;
    private float recorrido = 0;
    private bool bandera = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bandera)
        {
            transform.Translate(-speed * 5*Time.deltaTime, 0, 0, Space.World);
            recorrido += speed;
        }
        else{
            transform.Translate(speed * 5*Time.deltaTime, 0, 0, Space.World);
            recorrido -= speed;
        }
        if (recorrido == 320)
        {
            bandera = false;
        }
        else if (recorrido == -55) {
            bandera = true;
        }
    }
}
