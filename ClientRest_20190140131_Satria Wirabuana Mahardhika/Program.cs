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
    class Program
    {
        static void Main(string[] args)
        {
            ClassData cl = new ClassData();
            cl.getData();
            Program app = new Program();
            app.BuatMahasiswa();
            Console.ReadLine();
        }

        string baseurl = "http://localhost:1907/";

        void BuatMahasiswa()
        {
            Mahasiswa mhs = new Mahasiswa();
            Console.Write("Masukkan Nama: ");
            mhs.nama = Console.ReadLine();

            Console.Write("Masukkan NIM: ");
            mhs.nim = Console.ReadLine();

            Console.Write("Masukkan Prodi: ");
            mhs.prodi = Console.ReadLine();

            Console.Write("Masukkan Angkatan: ");
            mhs.angkatan = Console.ReadLine();

            var data = JsonConvert.SerializeObject(mhs);
            var postdata = new WebClient();
            postdata.Headers.Add(HttpRequestHeader.ContentType, "Application/json");
            string response = postdata.UploadString(baseurl + "Mahasiswa", data);
            Console.WriteLine(response);
        }
    }

    [DataContract]
    public class Mahasiswa
    {
        private string _nama, _nim, _prodi, _angkatan;
        [DataMember]
        public string nama
        {
            get { return _nama; }
            set { _nama = value; }
        }
        [DataMember]
        public string nim
        {
            get { return _nim; }
            set { _nim = value; }
        }
        [DataMember]
        public string prodi
        {
            get { return _prodi; }
            set { _prodi = value; }
        }
        [DataMember]
        public string angkatan
        {
            get { return _angkatan; }
            set { _angkatan = value; }
        }
    }
}
