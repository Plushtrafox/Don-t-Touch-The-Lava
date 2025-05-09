using UnityEngine;

public class PortadorJugable : PortadorBase
{
    [SerializeField] private ControladorHabilidades abilityController;

    public float manaMaximo = 100f;
    private float manaActual;

    protected ControladorHabilidades AbilityController => abilityController;

    protected override void Start()
    {
        base.Start();
        manaActual = manaMaximo;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1)) abilityController.CastAbility(0);
        if (Input.GetKeyUp(KeyCode.Alpha2)) abilityController.CastAbility(1);
        if (Input.GetKeyUp(KeyCode.Alpha3)) abilityController.CastAbility(2);
    }

    public bool UsarMana(float cantidad)
    {
        if (manaActual >= cantidad)
        {
            manaActual -= cantidad;
            return true;
        }
        return false;
    }
}
