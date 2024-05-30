namespace comex.Menus
{
    internal class MenuSair: MenuPrincipal
    {
        public override void Executar()
        {
            Console.WriteLine("Até mais!");
            Thread.Sleep(1000);
        }
    }
}
