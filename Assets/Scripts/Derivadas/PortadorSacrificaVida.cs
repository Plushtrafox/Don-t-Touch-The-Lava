public class PortadorSacrificaVida : PortadorBase
{
    public bool UsarVida(float cantidad)
    {
        if (vidaActual > cantidad)
        {
            RecibirDaño(cantidad);
            return true;
        }
        return false;
    }
}
