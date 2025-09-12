using MonitorCtrlID.Src.Middleware;
using System.Net;
using System.Runtime.Serialization.Json;

namespace MonitorCtrlID.Src.Services
{
  class WebJsonService
  {
    static WebJsonService()
    {
      ServicePointManager.Expect100Continue = false;
    }

    // Método para enviar requisição POST
    static public string Send(string uri, string data, string session = null)
    {
      if (session != null)
        uri += ".fcgi?session=" + session;
      else
        uri += ".fcgi";

      try
      {
        var request = (HttpWebRequest)WebRequest.Create(uri);
        request.ContentType = "application/json";
        request.Method = "POST";

        using (var streamWriter = new StreamWriter(request.GetRequestStream()))
        {
          streamWriter.Write(data);
        }

        var response = (HttpWebResponse)request.GetResponse();
        using (var streamReader = new StreamReader(response.GetResponseStream()))
        {
          return streamReader.ReadToEnd();
        }
      }
      catch (WebException e)
      {
        using (WebResponse response = e.Response)
        {
          HttpWebResponse httpResponse = (HttpWebResponse)response;
          //Console.WriteLine("Error code: {0}", httpResponse.StatusCode);
          using (Stream responseData = response.GetResponseStream())
          using (var reader = new StreamReader(responseData))
          {
            throw new Exception(reader.ReadToEnd());
          }
        }
      }
    }


    public async static Task<string> Send2(string uri, string session = null)
    {
      if (session != null)
        uri += ".fcgi?session=" + session;
      else
        uri += ".fcgi";

      try
      {
        var request = (HttpWebRequest)WebRequest.Create(uri);
        request.ContentType = "application/json";
        request.Method = "POST";


        var response = (HttpWebResponse)request.GetResponse();
        using (var streamReader = new StreamReader(response.GetResponseStream()))
        {
          return streamReader.ReadToEnd();
        }
      }
      catch (WebException e)
      {
        using (WebResponse response = e.Response)
        {
          HttpWebResponse httpResponse = (HttpWebResponse)response;
          //Console.WriteLine("Error code: {0}", httpResponse.StatusCode);
          using (Stream responseData = response.GetResponseStream())
          using (var reader = new StreamReader(responseData))
          {
            var newEX = new Exception(reader.ReadToEnd());
            await Logger.LogError(newEX);
            throw newEX;
          }
        }
      }
    }

    // Método para enviar requisição POST com retorno tipado
    static public T Send<T>(string uri, string data, string session = null)
    {
      if (session != null)
        uri += ".fcgi?session=" + session;
      else
        uri += ".fcgi";

      try
      {
        var request = (HttpWebRequest)WebRequest.Create(uri);
        request.ContentType = "application/json";
        request.Method = "POST";

        using (var streamWriter = new StreamWriter(request.GetRequestStream()))
        {
          streamWriter.Write(data);
        }

        var response = (HttpWebResponse)request.GetResponse();
        var serializer = new DataContractJsonSerializer(typeof(T));
        return (T)serializer.ReadObject(response.GetResponseStream());
      }
      catch (WebException e)
      {
        using (WebResponse response = e.Response)
        {
          HttpWebResponse httpResponse = (HttpWebResponse)response;
          Console.WriteLine("Error code: {0}", httpResponse.StatusCode);
          using (Stream responseData = response.GetResponseStream())
          using (var reader = new StreamReader(responseData))
          {
            var newEX = new Exception(reader.ReadToEnd());
            Logger.LogError(newEX);
            throw newEX;
          }
        }
      }
    }

    // Método para enviar requisição GET
    static public string Get(string uri, string session = null)
    {
      if (session != null)
        uri += ".fcgi?session=" + session;
      else
        uri += ".fcgi";

      try
      {
        var request = (HttpWebRequest)WebRequest.Create(uri);
        request.ContentType = "image/jpeg";
        request.Method = "GET";

        var response = (HttpWebResponse)request.GetResponse();
        using (var streamReader = new StreamReader(response.GetResponseStream()))
        {
          return streamReader.ReadToEnd();
        }
      }
      catch (WebException e)
      {
        using (WebResponse response = e.Response)
        {
          HttpWebResponse httpResponse = (HttpWebResponse)response;
          Console.WriteLine("Error code: {0}", httpResponse.StatusCode);
          using (Stream responseData = response.GetResponseStream())
          using (var reader = new StreamReader(responseData))
          {
            var newEX = new Exception(reader.ReadToEnd());
            Logger.LogError(newEX);
            throw newEX;
          }
        }
      }
    }

    // Método para enviar requisição GET com retorno tipado
    static public T Get<T>(string uri, string session = null)
    {
      if (session != null)
        uri += ".fcgi?session=" + session;
      else
        uri += ".fcgi";

      try
      {
        var request = (HttpWebRequest)WebRequest.Create(uri);
        request.ContentType = "image/jpeg";
        request.Method = "GET";

        var response = (HttpWebResponse)request.GetResponse();
        var serializer = new DataContractJsonSerializer(typeof(T));
        return (T)serializer.ReadObject(response.GetResponseStream());
      }
      catch (WebException e)
      {
        using (WebResponse response = e.Response)
        {
          HttpWebResponse httpResponse = (HttpWebResponse)response;
          Console.WriteLine("Error code: {0}", httpResponse.StatusCode);
          using (Stream responseData = response.GetResponseStream())
          using (var reader = new StreamReader(responseData))
          {
            var newEX = new Exception(reader.ReadToEnd());
            Logger.LogError(newEX);
            throw newEX;
          }
        }
      }
    }
  }
}
