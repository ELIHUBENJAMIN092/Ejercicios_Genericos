public class NameStack
{
    private List<string> elements = new List<string>();

    // Agrega un nombre al stack
    public void Push(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("El nombre no puede estar vacío o ser nulo.");
        elements.Add(name);
    }

    // Remueve y devuelve el último nombre del stack
    public string Pop()
    {
        if (elements.Count == 0)
            throw new InvalidOperationException("El stack está vacío.");

        string name = elements[^1];
        elements.RemoveAt(elements.Count - 1);
        return name;
    }

    // Devuelve el número de nombres en el stack
    public int Count => elements.Count;
}

// Uso
public class Program
{
    public static void Main()
    {
        NameStack nameStack = new NameStack();

        // Agregar nombres al stack
        nameStack.Push("Juan");
        nameStack.Push("María");
        nameStack.Push("Carlos");

        // Sacar y mostrar nombres del stack
        Console.WriteLine($"Popped: {nameStack.Pop()}"); // Output: Popped: Carlos
        Console.WriteLine($"Popped: {nameStack.Pop()}"); // Output: Popped: María

        // Verificar el número de elementos restantes
        Console.WriteLine($"Count: {nameStack.Count}"); // Output: Count: 1
    }
}