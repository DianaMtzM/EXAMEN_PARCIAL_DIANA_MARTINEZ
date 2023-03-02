using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SCRIPT : MonoBehaviour
{
    [SerializeField] private TMP_Text vototomado;
    [SerializeField] private TMP_Text textovoto;
    [SerializeField] private TMP_Text textocontrafavor;
    [SerializeField] private TMP_Text contador;
    public int voto;


    // Start is called before the first frame update
    void Start()
    {
        vototomado.text = "Estas a favor o en contra, por favor vota.";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Contar()
    {


        if (voto == 1 && voto == 0)      //1=favor, 0=contra
        {
            textovoto.text = "Tu voto no se ha registrado";
        }
        else
        {
            textovoto.text = "Tu voto se ha registrado";
            for (int i = 0; i < voto; i++) {

            }

        }
    }

    public void Comparar(int valor)
    {
        voto = valor;

        if (voto == 0)
        {
            textocontrafavor.text = "Tu voto es en contra";
        }
        else if (voto == 1)
        {
            textocontrafavor.text = "Tu voto es a favor";
        }
    }

    public void Imprimir()
    {
        if (voto == 0)
        {
            contador.text = "Ganaron en contra";
        }
        else if (voto == 1)
        {
            contador.text = "Ganaron a favor";
        }
        
        }


    public void Reboot()
    {
        SceneManager.LoadScene(0);
    }
}
