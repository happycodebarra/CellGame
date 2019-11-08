using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GerenciadorDeCenas : MonoBehaviour
{
   void mudarCena(string nomeDaCena)
    {
        Scene.LoadScene(nomeDaCena); 
    }
    
}
