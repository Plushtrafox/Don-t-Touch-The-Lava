public class PortadorConMana : PortadorBase
{
    public float manaMaximo = 100f;
    public float manaActual;

    protected override void Start()
    {
        base.Start();
        manaActual = manaMaximo;
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
