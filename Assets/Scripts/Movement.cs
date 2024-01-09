using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f; // define a velocidade de movimento do objeto

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // movimento horizontal
        float verticalInput = Input.GetAxis("Vertical"); // movimento vertical

        // realiza o calculo de movimento
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput) * speed * Time.deltaTime;

        // aplica a movimentacao ao objeto
        transform.Translate(movement, Space.World);   
    }
}
