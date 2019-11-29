using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoCelular : MonoBehaviour
{
    public GameObject celula;

    // QR Code Objects
    public GameObject nucleoQRCode, mitocondriaQRCode, lisossomoQRCode, reticuloQRCode;

    // Objetos na celula
    public GameObject nucleo, mitocondria, lisossomo, reticulo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var distanciaCelulaNucleo = Vector3.Distance(celula.transform.position, nucleoQRCode.transform.position);
        var distanciaCelulaMitocondrias = Vector3.Distance(celula.transform.position, mitocondriaQRCode.transform.position);
        var distanciaCelularLisossomo = Vector3.Distance(celula.transform.position, lisossomoQRCode.transform.position);
        var distanciaCelularReticulo = Vector3.Distance(celula.transform.position, reticuloQRCode.transform.position);


        if (distanciaCelulaNucleo < 1.5)
        {
            nucleo.SetActive(true); 
            nucleoQRCode.SetActive(false);
        }

        else if (distanciaCelulaMitocondrias < 1.5)
        {
            mitocondria.SetActive(true);
            mitocondriaQRCode.SetActive(false);
        }

        else if (distanciaCelularLisossomo < 1.5)
        {
            lisossomo.SetActive(true);
            lisossomoQRCode.SetActive(false);
        }

        else if (distanciaCelularReticulo < 1.5)
        {
            reticulo.SetActive(true);
            reticulo.SetActive(false);
        }
    }
}
