namespace ISP.FileManage.Good;

public interface IFileManage
{
    void Create(string PathName,string Name, string data);
    string Read(string PathName, string Name);
   

}
