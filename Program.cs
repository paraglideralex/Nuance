var Petka = new Petka();
var Chapaev = new Chapaev();

Console.WriteLine($"У Петьки: { Petka.HasDickInAss}, У Чапаева: {Chapaev.HasDickInAss}");
// У Петьки: False, У Чапаева: False
Chapaev.Friction(Petka);
Console.WriteLine($"У Петьки: {Petka.HasDickInAss}, У Чапаева: {Chapaev.HasDickInAss}");
// У Петьки: True, У Чапаева: True

public abstract class Human
{
    protected Dick dick = new();
    protected Ass ass = new();
    public bool HasDickInAss => Nuance();

    protected abstract bool Nuance();

    public void GetDick() => ass.GetDick(dick);
}

public class Petka : Human
{
    protected override bool Nuance() => ass.HasDick;
}

public class Chapaev : Human
{
    private Human? submissive;

    protected override bool Nuance() => submissive == null
            ? false
            : ass.HasDick || submissive.HasDickInAss;

    public void Friction(Human human)
    {
        human.GetDick();
        submissive = human;
    }
}

public class Dick() {}

public class Ass()
{
    private Dick? innerDick;
    public bool HasDick => innerDick != null;

    public void GetDick(Dick dick) => innerDick = dick;
}