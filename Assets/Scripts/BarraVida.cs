using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public Image rellenoBarraVida;
    private PlayerController playerController;
    private float vidaMaxima;
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        vidaMaxima = playerController.vida;
    }

    // Update is called once per frame
    void Update()
    {
        rellenoBarraVida.illAmount = playerController.vida / vidaMaxima;
    }
}
