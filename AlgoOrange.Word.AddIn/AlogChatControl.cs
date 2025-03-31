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
        //private const string MessageHistoryFilePath = "ChatHistory.txt";
        //private Label label3;
        //private RichTextBox richTextBox1.text;
        //private const string LogoImagePath = @"C:\AlgoOrange.Excel.AddIn\icon.png"; // Store the image path as a constant

        //public ChatControl()
        //{
        //    InitializeComponent();
        //    LoadMessageHistory();
        //    LoadLogo(); // Call LoadLogo to load the image when the control is created
        //}

        //private void InitializeComponent()
        //{



        //}
        private ThisAddIn addIn;

        public AlogChatControl(ThisAddIn addIn)
        {
            InitializeComponent();
            this.addIn = addIn;
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

                    // Wrap the data in an object with a "data" field
                    // var wrappedData = new { data = jsonData, userQuery = "Hai", chatHistory = "Wow" };
                    var wrappedData = new { data = JsonConvert.SerializeObject(jsonData), userQuery = userQuery, chatHistory = chatHistory };
                    string wrappedJsonData = JsonConvert.SerializeObject(wrappedData);

                    StringContent content = new StringContent(wrappedJsonData, Encoding.UTF8, "application/json");

                    // Log the JSON data being sent
                    Debug.WriteLine("Sending JSON data: " + wrappedJsonData);


                    HttpResponseMessage response = client.PostAsync("/excel/query", content).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string result = response.Content.ReadAsStringAsync().Result;

                        // Parse the JSON response
                        var jsonResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(result);

                        // Display the "message" field in the textbox
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

    }
}
