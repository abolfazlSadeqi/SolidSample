namespace ISP.FileManage.Good;

public interface IFileUpdate: IFileManage
{
  
    void Update(string PathName, string Name, string data);

}
