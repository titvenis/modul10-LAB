
public interface IFileSystemComponent
{
    void Display(int depth);
    void Add(IFileSystemComponent component);
    void Remove(IFileSystemComponent component);
    IFileSystemComponent GetChild(int index);
}

public class File : IFileSystemComponent
{
    private string _name;

    public File(string name)
    {
        _name = name;
    }

    public void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + " File: " + _name);
    }

    public void Add(IFileSystemComponent component)
    {
        throw new NotImplementedException();
    }

    public void Remove(IFileSystemComponent component)
    {
        throw new NotImplementedException();
    }

    public IFileSystemComponent GetChild(int index)
    {
        throw new NotImplementedException();
    }
}

public class Directory : IFileSystemComponent
{
    private string _name;
    private List<IFileSystemComponent> _children = new List<IFileSystemComponent>();

    public Directory(string name)
    {
        _name = name;
    }

    public void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + " Directory: " + _name);
        foreach (var component in _children)
        {
            component.Display(depth + 2);
        }
    }

    public void Add(IFileSystemComponent component)
    {
        _children.Add(component);
    }

    public void Remove(IFileSystemComponent component)
    {
        _children.Remove(component);
    }

    public IFileSystemComponent GetChild(int index)
    {
        return _children[index];
    }
}

class Program
{
    static void Main(string[] args)
    {
        IFileSystemComponent root = new Directory("Root");
        IFileSystemComponent file1 = new File("File1.txt");
        IFileSystemComponent file2 = new File("File2.txt");
        IFileSystemComponent subDir = new Directory("SubDirectory");
        IFileSystemComponent subFile1 = new File("SubFile1.txt");

        root.Add(file1);
        root.Add(file2);
        subDir.Add(subFile1);
        root.Add(subDir);

        root.Display(1);
    }
}
