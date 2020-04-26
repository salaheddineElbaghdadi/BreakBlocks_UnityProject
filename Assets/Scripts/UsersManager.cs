using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UIElements;

public class UsersManager : MonoBehaviour
{
    private string userDataFileName = "/users.json";
    private string userDataFilePath;

    private string ReadUserData()
    {
        userDataFilePath = Application.streamingAssetsPath + userDataFileName;
        return "";
    }

    public void WriteUserData(User user)
    {
        userDataFilePath = Application.streamingAssetsPath + userDataFileName;

        using (FileStream file = File.Exists(userDataFilePath) ? 
            File.Open(userDataFilePath, FileMode.Append) : File.Open(userDataFilePath, FileMode.Create))
        {
            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.WriteLine(user.toJsonFormat());
            }
        }
    }
}
