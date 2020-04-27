using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Net.NetworkInformation;
using Google.Apis.Download;

namespace GGDriveTool.api
{
    public class GoogleDriveAPI
    {
        private DriveService Get_Google_Drive_Service(string setpathTokenName)
        {
            string[] Scopes = { DriveService.Scope.Drive };
            string ApplicationName = "GGConsoleTest";

            // Xác thực quyền truy cập vào google drive
            UserCredential credential;
            using (var stream = new FileStream("client_secret_187952358879-ja2hk2dlcq4bvihpng6couea2s68np80.apps.googleusercontent.com.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                // Xác thực tài khoản đăng nhập vào google drive của người dùng lần đầu tiên sau khi người dùng đăng nhập
                // thông tin sẽ được lưu vào "token.json" và lần chạy chương trình, sẽ lấy thông tin đăng nhập lại từ đây
                // và người dùng không phải đăng nhập lại

                string credPath = setpathTokenName + ".json";

                // Yêu cầu người dùng xác thực lần đầu và thông tin sẽ được lưu vào thư mục token.json
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }


            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            return service;
        }

        public IList<Google.Apis.Drive.v3.Data.File> Search_Somethings(string name_token, string mindType)
        {
            FilesResource.ListRequest listRequest = Get_Google_Drive_Service(name_token).Files.List();

            IList<Google.Apis.Drive.v3.Data.File> contents = listRequest.Execute().Files;
            listRequest.Q = mindType;

            contents = listRequest.Execute().Files;

            return contents;
        }

        public void Upload_to_Root(string nameFile, string FilePath, string name_token)
        {
            //string[] arrListStr = textBox1.Text.Split('\\');
            //string nameFile = arrListStr[arrListStr.Length - 1];

            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = nameFile
            };

            FilesResource.CreateMediaUpload request;

            using (var stream = new System.IO.FileStream(FilePath,
                                    System.IO.FileMode.Open))
            {
                request = Get_Google_Drive_Service(name_token).Files.Create(fileMetadata, stream, fileMetadata.MimeType);

                request.Upload();
            }
        }
    }
}
