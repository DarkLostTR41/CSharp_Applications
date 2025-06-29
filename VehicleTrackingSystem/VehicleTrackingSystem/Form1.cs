using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace VehicleTrackingSystem
{
    public partial class Form1 : Form
    {
        private List<Vehicle> vehicles = new List<Vehicle>();
        private string dataFile = Path.Combine(Application.StartupPath, "vehicles.json");

        public Form1()
        {
            InitializeComponent();
            LoadData();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            File.WriteAllText(dataFile, JsonConvert.SerializeObject(vehicles));
        }

        private void LoadData()
        {
            if (File.Exists(dataFile))
            {
                vehicles = JsonConvert.DeserializeObject<List<Vehicle>>(File.ReadAllText(dataFile));
                // vehicleDataList'i de doldur
                vehicleDataList.Clear();
                foreach (var v in vehicles)
                {
                    vehicleDataList.Add(new string[]
                    {
                        v.Id,
                        v.Plaka,
                        v.Marka,
                        v.Model,
                        v.Kilometre,
                        v.Renk,
                        v.SasiNo,
                        v.HasarKaydi,
                        v.Mtv,
                        v.Ceza,
                        v.MuayeneTarihi
                    });
                }
            }
        }

        // Class-level list to store vehicle data
        private List<string[]> vehicleDataList = new List<string[]>();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Yeni araç nesnesi oluşturuluyor ve vehicles listesine ekleniyor
            Vehicle newVehicle = new Vehicle
            {
                Id = Guid.NewGuid().ToString(),
                Plaka = txtK_plaka.Text,
                Marka = txtK_Marka.Text,
                Model = txtK_Model.Text,
                Kilometre = txtK_kilometre.Text,
                Renk = txtK_Renk.Text,
                SasiNo = txtK_SasiNo.Text,
                HasarKaydi = txtK_HasarKaydi.Text,
                Mtv = txtK_Mtv.Text,
                Ceza = txtK_Ceza.Text,
                MuayeneTarihi = txtK_MuayeneTarihi.Text
            };

            vehicles.Add(newVehicle);

            // vehicleDataList'e de ekleyebilirsiniz, ancak asıl veri vehicles listesinde tutulmalı
            string[] vehicleData = new string[]
            {
                newVehicle.Id,
                newVehicle.Plaka,
                newVehicle.Marka,
                newVehicle.Model,
                newVehicle.Kilometre,
                newVehicle.Renk,
                newVehicle.SasiNo,
                newVehicle.HasarKaydi,
                newVehicle.Mtv,
                newVehicle.Ceza,
                newVehicle.MuayeneTarihi
            };
            vehicleDataList.Add(vehicleData);

            ClearVehicleTextboxes();
        }

        private void ClearVehicleTextboxes()
        {
            txtK_plaka.Clear();
            txtK_Marka.Clear();
            txtK_Model.Clear();
            txtK_kilometre.Clear();
            txtK_Renk.Clear();
            txtK_SasiNo.Clear();
            txtK_HasarKaydi.Clear();
            txtK_Mtv.Clear();
            txtK_Ceza.Clear();
            txtK_MuayeneTarihi.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchPlaka = textBox11.Text.Trim();
            foreach (var vehicle in vehicleDataList)
            {
                // vehicle[1] is Plaka
                if (vehicle[1].Equals(searchPlaka, StringComparison.OrdinalIgnoreCase))
                {
                    infoMarka.Text = vehicle[2];
                    infoModel.Text = vehicle[3];
                    infoKilometre.Text = vehicle[4];
                    infoRenk.Text = vehicle[5];
                    infoSasiNo.Text = vehicle[6];
                    infoHasarKaydi.Text = vehicle[7];
                    infoMtv.Text = vehicle[8];
                    infoCeza.Text = vehicle[9];
                    infoMuayeneTarihi.Text = vehicle[10];
                    return;
                }
            }
            // Optionally clear labels if not found
            infoMarka.Text = "";
            infoModel.Text = "";
            infoKilometre.Text = "";
            infoRenk.Text = "";
            infoSasiNo.Text = "";
            infoHasarKaydi.Text = "";
            infoMtv.Text = "";
            infoCeza.Text = "";
            infoMuayeneTarihi.Text = "";
        }
    }
}
namespace VehicleTrackingSystem
{
    public class Vehicle
    {
        public string Id { get; set; }
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Kilometre { get; set; }
        public string Renk { get; set; }
        public string SasiNo { get; set; }
        public string HasarKaydi { get; set; }
        public string Mtv { get; set; }
        public string Ceza { get; set; }
        public string MuayeneTarihi { get; set; }
    }
}       