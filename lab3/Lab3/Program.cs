using System.Reflection;

namespace Lab3;

class Program {
    static void Main(string[] args) {
        string libraryName = args[0];

        Assembly assembly = Assembly.UnsafeLoadFrom(libraryName);
        Type typeToCreate = null;
        foreach (Type type in assembly.GetTypes()) {
        }
    }
}
