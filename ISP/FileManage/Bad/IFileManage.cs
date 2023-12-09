namespace ISP.FileManage.Bad;

public interface IFileManage
{
    void Create(string PathName,string Name, string data);
    string Read(string PathName, string Name);
    void Update(string PathName, string Name, string data);
    void DecodeFile(string PathName, string Name, string data);

}
