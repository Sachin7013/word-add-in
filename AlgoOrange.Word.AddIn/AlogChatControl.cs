using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MsWord = Microsoft.Office.Interop.Word;

namespace AlgoOrange.Word.AddIn
{
    public partial class AlogChatControl : UserControl
    {
        private ThisAddIn addIn;

        public AlogChatControl(ThisAddIn addIn)
        {
            InitializeComponent();
            this.addIn = addIn;
            LoadLogo(); // Call LoadLogo to load the image when the control is created
        }

        private void LoadLogo()
        {
            string imagePath = @"C:\Users\Manoj\OneDrive\Desktop\AlgoOrange.Word.AddIn\AlgoOrange.Word.AddIn\icon.png";
            if (System.IO.File.Exists(imagePath))
            {
                this.pictureBox2.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("Image file not found: " + imagePath);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MsWord.Document doc = addIn.Application.ActiveDocument;
            string wordContent = doc.Content.Text;

            SendXLSDataToAlgoAPI(wordContent, textBox1.Text);
        }

        private void SendXLSDataToAlgoAPI(string jsonData, string userQuery = null, string chatHistory = null)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("http://127.0.0.1:8000/");

                    var wrappedData = new { data = JsonConvert.SerializeObject(jsonData), userQuery = userQuery, chatHistory = chatHistory };
                    string wrappedJsonData = JsonConvert.SerializeObject(wrappedData);

                    StringContent content = new StringContent(wrappedJsonData, Encoding.UTF8, "application/json");

                    Debug.WriteLine("Sending JSON data: " + wrappedJsonData);

                    HttpResponseMessage response = client.PostAsync("/excel/query", content).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string result = response.Content.ReadAsStringAsync().Result;

                        var jsonResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(result);

                        this.Invoke((MethodInvoker)delegate { richTextBox3.Text = jsonResponse.message.ToString(); });
                    }
                    else
                    {
                        this.Invoke((MethodInvoker)delegate { richTextBox3.Text = $"Error: {response.StatusCode}"; });
                    }
                }
                catch (Exception ex)
                {
                    this.Invoke((MethodInvoker)delegate { richTextBox3.Text = $"Exception: {ex.Message}"; });
                }
            }
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AlogChatControl_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
