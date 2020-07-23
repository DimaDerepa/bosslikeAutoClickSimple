
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace bosslike
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();



            webBrowser12.Url  = new Uri("https://www.instagram.com/antonigorev2020/");
            status.Text = "Приложение запущено";
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void Points_TextChanged(object sender, EventArgs e)
        {

        }

        private void DoneOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {

            status.Text = "Запускаюсь";
            pause(5000);
            if (comboBox1.Text == "Подписки")
            {
                followTask();
            }
            else if (comboBox1.Text == "Лайки")
            {
                likeTask();
            }
        }
        private JObject getjson(string url)
        {
            HttpWebRequest request =
             (HttpWebRequest)WebRequest.Create(url);

            request.Method = "GET";
            request.Accept = "application/json";
            request.Headers["X-Api-Key"] = "04e86f019e06d3a1ae861d6c87e29fcf722385bee27bfbeb";
            try
            {
                HttpWebResponse response2 = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException ex)
            {
                HttpWebResponse errorResponse = (HttpWebResponse)ex.Response;
                if (!(errorResponse.StatusCode == HttpStatusCode.OK))
                {
                    string ps = "";
                    var po =(JObject)JsonConvert.DeserializeObject(ps);
                    return po;
                }

            }
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            StringBuilder output = new StringBuilder();
            output.Append(reader.ReadToEnd());
            response.Close();
            var promJsonTasks = (JObject)JsonConvert.DeserializeObject(output.ToString());
            
            return promJsonTasks;
        }
        private void openurl(string url)
        {
            webBrowser12.Url = new Uri(url);
            Random rnd = new Random();
            int sluchay = rnd.Next(0, 3000);
            pause(7000+sluchay);
        }
        private void clickFollow()
        {
            
            
             HtmlElementCollection buttons = webBrowser12.Document.GetElementsByTagName("button");
            if (!(buttons == null))
            {
                status.Text = "Нажимаю кнопку";
                buttons[1].InvokeMember("Click");
                pause(2000);
               
            }
            else
            {
                status.Text = "Ошибка";
                pause(1500);
                return;
               
            }
        }
        private void clickLike()
        {


            HtmlElementCollection buttons = webBrowser12.Document.GetElementsByTagName("button");
            if (!(buttons == null))
            {
                foreach(HtmlElement button in buttons)
                {
                    button.InvokeMember("Click");
                }
  
                
               
                pause(2000);

            }
            else
            {
                status.Text = "Ошибка";
                pause(1500);
                return;

            }
        }


        public void pause(int vr)
        {
            double time = DateTime.Now.TimeOfDay.TotalMilliseconds;
            while ((DateTime.Now.TimeOfDay.TotalMilliseconds - time) < vr)
            {
                Application.DoEvents();
            }

        }
        public void followTask()
        {
            progressBar1.Step = 1;
            var countGoalvar = countGoal.Text;
            var Goalint = 0;
            if (countGoalvar == "")
            {
                Goalint++;
            }
            else
            {
                Goalint = Convert.ToInt32(countGoalvar);
            }
            progressBar1.Maximum = (Goalint * 20);
            for (int j = 0; j < Goalint; j++)
            {
                string bosslikeTasks = "https://api-public.bosslike.ru/v1/bots/tasks/?service_type=3&task_type=3";
                status.Text = "Получаю таски";
                pause(1500);
                var jobj = getjson(bosslikeTasks);

                for (int i = 0; i < 20; i++)
                {
                    progressBar1.PerformStep();
                    int currentTask = ((j + 1) * 20) + i - 19;
                    status.Text = "Получаю- " + currentTask + " -задание";
                    pause(1500);
                    string taskId = jobj["data"]["items"][i]["id"].ToString();
                    var taskInfo = getjson("https://api-public.bosslike.ru/v1/bots/tasks/" + taskId + "/do/");
                    if (taskInfo == null) { status.Text = "Ошибка"; pause(1500); continue; }
                    string instUrl = taskInfo["data"]["url"].ToString();
                    status.Text = "Загружаю-" + currentTask + "-задание";
                    pause(1500);
                    openurl(instUrl);
                    status.Text = "Подписываюсь";
                    clickFollow();
                    var taskCheck = getjson("https://api-public.bosslike.ru/v1/bots/tasks/" + taskId + "/check/");
                    if (taskCheck == null) { status.Text = "Ошибка"; pause(1500); continue; }
                    status.Text = "Проверка- " + currentTask + " -задание";
                    pause(1500);
                    string checkedInfo = taskCheck["data"]["user"]["point"].ToString();
                    Points.Text = checkedInfo;
                    DoneOutput.Text = "" + currentTask;
                    double progresschis = 5 * currentTask / Goalint;
                    progress.Text = progresschis + "%";
                    double lfe = (20 * Goalint) - currentTask;
                    LastForEnd.Text = "" + lfe;
                    GC.Collect();
                }
            }
            status.Text = "Завершено";

        }
        public void likeTask()
        {
            progressBar1.Step = 1;
            var countGoalvar = countGoal.Text;
            var Goalint = 0;
            if (countGoalvar == "")
            {
                Goalint++;
            }
            else
            {
                Goalint = Convert.ToInt32(countGoalvar);
            }
            progressBar1.Maximum = (Goalint * 20);
            for (int j = 0; j < Goalint; j++)
            {
                string bosslikeTasks = "https://api-public.bosslike.ru/v1/bots/tasks/?service_type=3&task_type=1";
                status.Text = "Получаю таски";
                pause(1500);
                var jobj = getjson(bosslikeTasks);

                for (int i = 0; i < 20; i++)
                {
                    progressBar1.PerformStep();
                    int currentTask = ((j + 1) * 20) + i - 19;
                    status.Text = "Получаю- " + currentTask + " -задание";
                    pause(1500);
                    string taskId = jobj["data"]["items"][i]["id"].ToString();
                    var taskInfo = getjson("https://api-public.bosslike.ru/v1/bots/tasks/" + taskId + "/do/");
                    if (taskInfo == null) { status.Text = "Ошибка"; pause(1500); continue; }
                    string instUrl = taskInfo["data"]["url"].ToString();
                    status.Text = "Загружаю-" + currentTask + "-задание";
                    pause(1500);
                    openurl(instUrl);
                    status.Text = "Лайкаю";
                    clickLike();
                    var taskCheck = getjson("https://api-public.bosslike.ru/v1/bots/tasks/" + taskId + "/check/");
                    if (taskCheck == null) { status.Text = "Ошибка"; pause(1500); continue; }
                    status.Text = "Проверка- " + currentTask + " -задание";
                    pause(1500);
                    string checkedInfo = taskCheck["data"]["user"]["point"].ToString();
                    Points.Text = checkedInfo;
                    DoneOutput.Text = "" + currentTask;
                    double progresschis = 5 * currentTask / Goalint;
                    progress.Text = progresschis + "%";
                    double lfe = (20 * Goalint) - currentTask;
                    LastForEnd.Text = "" + lfe;
                    GC.Collect();
                }
            }
            status.Text = "Завершено";

        }
        private void reload_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        public void status_TextChanged(object sender, EventArgs e)
        {

        }

        public void geckoWebBrowser1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
