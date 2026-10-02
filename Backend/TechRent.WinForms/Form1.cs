using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;

namespace TechRent.WinForms
{
    public partial class Form1 : Form
    {
        // HttpClient az API hívásokhoz
        private static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        // Ezt kereste a Designer és most már itt van!
        private async void btnBetoltes_Click(object sender, EventArgs e)
        {
            try
            {
                // Cseréld ki a 7001-et a saját API portodra!
                string apiUrl = "https://localhost:7001/api/devices";

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var devices = JsonSerializer.Deserialize<List<Device>>(responseBody, options);

                dataGridViewEszkozok.DataSource = devices;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a csatlakozáskor: " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // A modellosztály a bejövő adatokhoz
    public class Device
    {
        public int Id { get; set; }
        public string Megnevezes { get; set; }
        public string Kategoria { get; set; }
        public string Allapot { get; set; }
    }
}