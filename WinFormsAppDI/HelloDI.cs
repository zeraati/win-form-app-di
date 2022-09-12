namespace WinFormsAppDI
{
    public interface IHelloDI
    {
        string SeyHello();
    }

    public class HelloDI : IHelloDI
    {
        public string SeyHello() => "Hello DI!";
    }
}
