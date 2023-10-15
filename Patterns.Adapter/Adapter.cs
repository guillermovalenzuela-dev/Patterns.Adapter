namespace Patterns.Adapter;
public class Adapter : INewInterface
{
    private OldLibrary oldLibrary = new OldLibrary();

    public void NewMethod()
    {
        oldLibrary.OldMethod();
    }
}
