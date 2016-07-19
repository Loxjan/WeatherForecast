using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
namespace WeatherForecast
{
    public class StorageHelper
    {
        public const string alarmStorage = "AlarmData.dat";

        public static bool Serialize<T>(List<T> list, string path)
        {
            FileStream stream = null;

            try
            {
                //stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);

                //BinaryFormatter formatter = new BinaryFormatter();
                //formatter.Serialize(stream, list);

                //打开文件
                FileStream fileStream = new FileStream(path,
                    FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);

                //fileStream.Seek(0, SeekOrigin.Begin);
                //fileStream.SetLength(0); //清空txt文件

                XmlSerializer xs = new XmlSerializer(typeof(List<T>));
                xs.Serialize(fileStream, list);
                //fileStream.Close();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }

        public static List<T> Deserialize<T>(string path)
        {
            FileStream fileStream = null;
            try
            {
                //fileStream = new FileStream(path,
                //    FileMode.Open, FileAccess.Read, FileShare.Read);
                //BinaryFormatter bf = new BinaryFormatter();
                //List<T> list = bf.Deserialize(fileStream) as List<T>;

                fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                XmlSerializer xs = new XmlSerializer(typeof(List<T>));
                List<T> list = (List<T>)xs.Deserialize(fileStream);

                //fileStream.Close();

                return list;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (fileStream != null)
                    fileStream.Close();
            }

        }
    }
}
