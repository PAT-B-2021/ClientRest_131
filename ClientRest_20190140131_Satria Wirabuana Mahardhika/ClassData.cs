using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Net;
using System.Text;
using System.Threading.Tasks;
namespace ClientRest_20190140131_Satria_Wirabuana_Mahardhika
{
    class ClassData
    {
        public void getData()
        {
            var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);
        
            foreach(var mhs in data)
            {
                Console.WriteLine("NIM: " + mhs.nim);
                Console.WriteLine("Nama: " + mhs.nama);
                Console.WriteLine("Prodi: " + mhs.prodi);
                Console.WriteLine("Angkatan: " + mhs.angkatan);
            }
            Console.ReadLine();
        }
    }
}
