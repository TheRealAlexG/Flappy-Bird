using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorCamera : MonoBehaviour
{

    public GameObject jugador;
    private Vector3 desplaçament;
    // Start is called before the first frame update
    void Start()
    {
        desplaçament = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = jugador.transform.position + desplaçament;
        
    }
}
