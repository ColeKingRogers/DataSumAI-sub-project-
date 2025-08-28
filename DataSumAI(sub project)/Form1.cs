using Microsoft.Web.WebView2.Core;
using System.Net.Http.Json;
using System.Text.Json.Serialization;


namespace DataSumAI_sub_project_
{
    public partial class Form1 : Form
    {
        Root root = new Root();

        public Form1()
        {
            InitializeComponent();
            webView21.Source = new Uri("https://www.google.com/");
        }
        public async Task<string> GetSummaryAsync(string article, string question)
        {
            using var client = new HttpClient();
            var payload = new
            {
                model = "phi3:mini",
                prompt = $"Summarizes the article data in a way that answers the question, if the article can not answer the question only give a response saying that the article has invaild information to answer the question:\n\nArticle:\n{article}\n\nQuestion:\n{question}",
                stream = false
            };

            var response = await client.PostAsJsonAsync("http://localhost:11434/api/generate", payload);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            root = System.Text.Json.JsonSerializer.Deserialize<Root>(result);
            return root.Response;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (webView21.CoreWebView2 == null)
            {
                await webView21.EnsureCoreWebView2Async(null);
            }
            string question = textBox2.Text;

            string article = await webView21.ExecuteScriptAsync("document.body.innerText");
            article = System.Text.Json.JsonSerializer.Deserialize<string>(article);

            string summary = await GetSummaryAsync(article, question);
            richTextBox1.Text = summary;
            webView21.Source = new Uri("https://www.google.com/");
            textBox2.Text = "";
        }
        public class Root
        {
            [JsonPropertyName("response")]
            public string? Response { get; set; }

        }
    }
}
