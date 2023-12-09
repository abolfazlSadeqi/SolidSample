namespace ISP.FileManage.Good;

public interface IFileDecode : IFileManage
{

 
    void DecodeFile(string PathName, string Name, string data);

}