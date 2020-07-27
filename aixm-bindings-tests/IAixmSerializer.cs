namespace aixm_bindings_tests
{
    public interface IAixmSerializer<T>
    {
        T Deserialize(string input);

        string Serialize(T obj, bool namespacePrefixes = false);
    }
}
