using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoCelular : MonoBehaviour
{
    public GameObject celula;

    public GameObject nucleoQRCode;

    public GameObject nucleoCelula;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(celula.transform.position, nucleoQRCode.transform.position) < 1.5)
        {
            nucleoCelula.SetActive(true); 
            nucleoQRCode.SetActive(false);
        }
    }
}
