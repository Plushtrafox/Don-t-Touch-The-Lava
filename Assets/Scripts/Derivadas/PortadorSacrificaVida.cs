public class PortadorSacrificaVida : PortadorBase
{
    public bool UsarVida(float cantidad)
    {
        if (vidaActual > cantidad)
        {
            RecibirDa�o(cantidad);
            return true;
        }
        return false;
    }
}
