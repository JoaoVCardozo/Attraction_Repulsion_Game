using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repulsion : MonoBehaviour
{
    public Transform otherObject;

    public float repulsionForce = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate () {

        if (otherObject == null) return;

        // direcao de repulsao
        Vector3 direction = transform.position - otherObject.position;

        // calculo da forca com base na distancia (similar a lei de Coulomb)
        float distance = direction.magnitude;
        float repulsionMagnitude = repulsionForce / (distance * distance);

        // aplica a repulsao aos objetos
        GetComponent<Rigidbody>().AddForce(direction.normalized * repulsionMagnitude * Time.fixedDeltaTime);
        otherObject.GetComponent<Rigidbody>().AddForce(-direction.normalized * repulsionMagnitude * Time.fixedDeltaTime);
        
    }
}
