namespace RepasoPersona.Core
{
    public class Cuenta
    {
        public int _contador = 0;
        public int cbu { get; private set; }

        public Cuenta()
        {
            cbu = ++_contador;
        }
    }
}