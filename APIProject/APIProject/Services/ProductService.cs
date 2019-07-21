using APIProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace APIProject.Services
{
    public class ProductService : IProductService
    {
        
    public string Get(int id)
    {
        string product = LoadJson($"{id}.json");
        return product;
    }
    public string Add(Product product)
    {
        Random random = new Random();
        product.Id = random.Next();
        string json = null;
        string path = $"{Directory.GetCurrentDirectory()}{$@"\wwwroot\assets\products\{product.Id}.json"}";
           
        if (!System.IO.File.Exists(path))
        {
                //var logFile = System.IO.File.Create(path);
            System.IO.FileInfo file = new System.IO.FileInfo(path);
            file.Directory.Create();
            //var logWriter = new System.IO.StreamWriter(logFile);
            //logWriter.Dispose();
            json = JsonConvert.SerializeObject(product);
            System.IO.File.WriteAllText(path, json);
        }

        return json;
    }
    public string LoadJson(string filename)
    {
        string item = null;
        string path = $"{Directory.GetCurrentDirectory()}{$@"\wwwroot\assets\products\{filename}"}";
        if (System.IO.File.Exists(path))
        {
            FileStream fileStream = new FileStream(path, FileMode.Open);
            using (StreamReader r = new StreamReader(fileStream))
            {
                item = r.ReadToEnd();
            }
        }
        return item;
    }
}
}
