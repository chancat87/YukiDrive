using System.Collections.Generic;
using System.Threading.Tasks;
using YukiDrive.Models;

namespace YukiDrive.Services
{
    public interface IDriveService
    {
          public Task<List<DriveFile>> GetRootItems(string siteName);
          public Task<List<DriveFile>> GetDriveItemsById(string id,string siteName);
          public Task<List<DriveFile>> GetDriveItemsByPath(string path,string siteName);
          public Task<DriveFile> GetDriveItemByPath(string path,string siteName);
          public Task<DriveFile> GetDriveItemById(string id,string siteName);
    }
}