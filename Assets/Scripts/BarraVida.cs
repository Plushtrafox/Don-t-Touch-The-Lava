using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BarraVida : MonoBehaviour
{
    public UnityEngine.UI.Image rellenoBarraVida;
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
        rellenoBarraVida.fillAmount = playerController.vida / vidaMaxima;
    }
}

internal class PlayerController
{
    internal readonly float vida;
}