using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Camera_Script : MonoBehaviour
{
    public Transform target; // o objeto que a camera acompanha

    public float smoothSpeed = 1f; // velocidade de movimento da camera

    public Vector3 offset; // distancia entre o objeto e a camera

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate() {

        // verificação se há um objeto selecionado
        if (target == null){
            Debug.LogWarning("Nenhum objeto selecionado");
            return;
        }

        // define a posição da camera com base na posição do objeto + offset
        Vector3 desiredPosition = target.position + offset;

        // move a camera utilizando Lerp(movimentacao suave de ponto a ponto)
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
        
        //mantém a camera olhando para o objeto
        transform.LookAt(target);
    }
}
