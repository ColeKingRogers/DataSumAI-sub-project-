using System.Net.Http.Json;

namespace DataSumAI_sub_project_
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri(textBox1.Text);
            
        }
        public async Task<string> GetSummaryAsync(string article, string question)
        {
            using var client = new HttpClient();
            var payload = new
            {
                model = "phi3:mini", // or your specific model name
                prompt = $"Summarize the following article and answer the question:\n\nArticle:\n{article}\n\nQuestion:\n{question}",
                stream = false
            };

            var response = await client.PostAsJsonAsync("http://localhost:11434/api/generate", payload);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();
            return result; // You might need to deserialize JSON depending on the response format
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string question = textBox2.Text;

            string article = await webView21.ExecuteScriptAsync("document.body.innerText");
            article = System.Text.Json.JsonSerializer.Deserialize<string>(article); // Clean up the result

            string summary = await GetSummaryAsync(article, question);
            richTextBox2.Text = summary.Normalize();
        }

    }
}
