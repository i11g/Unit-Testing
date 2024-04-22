using System.IO;

static string GetFile(string? path)
{
    if (string.IsNullOrEmpty(path))
    {
        throw new ArgumentNullException(nameof(path));
    }

    string[] pathParts = path.Split(@"\");
    string file = pathParts[^1];

    if (file.IndexOf('.') == -1)
    {
        return $"File name: {file}";
    }

    return $"File name: {file.Split('.')[0]}\nFile extension: {file.Split('.')[1]}";
}
Console.WriteLine(GetFile("C:\\Users\\text.doc"));
