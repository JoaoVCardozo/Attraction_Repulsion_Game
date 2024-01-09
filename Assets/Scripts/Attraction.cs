using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractionScript : MonoBehaviour
{
    public Transform otherObject; // objeto a ser atraido

    public float attractionForce = 5f; // forca de atracao

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        
        if (otherObject == null) return;

        // direcao da atracao
        Vector3 direction = otherObject.position - transform.position;

        // aplica a forca de atracao usando a lei da gravitacao universal 
        float distance = direction.magnitude;
        float forceMagnitude = (attractionForce * GetComponent<Rigidbody>().mass * otherObject.GetComponent<Rigidbody>().mass / (distance * distance));

        // aplica nos objetos a forca calculada
        GetComponent<Rigidbody>().AddForce(direction.normalized * forceMagnitude * Time.fixedDeltaTime);
        otherObject.GetComponent<Rigidbody>().AddForce(-direction.normalized * forceMagnitude * Time.fixedDeltaTime);

    }
}
