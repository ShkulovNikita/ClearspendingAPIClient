using System;
using System.Windows.Forms;

namespace ClearspendingClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //задание начальных выбранных элементов выпадающих списков
            suppliersComboBox.SelectedIndex = 0;
            customersComboBox.SelectedIndex = 0;
            grantsComboBox.SelectedIndex = 0;
            contractsComboBox.SelectedIndex = 0;
        }

        //отображение текста-подсказки
        private void ShowHintText(string pathToFile)
        {
            string hintText = "";
            if (pathToFile != "")
                hintText = FilesHandler.ReadFile(pathToFile);
            hintTextBox.Text = hintText;
        }

        //обработка выбора элемента списка методов для контрактов
        private void contractsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pathToFile = FilesHandler.GetFilePath(0, contractsComboBox.SelectedIndex);
            ShowHintText(pathToFile);
        }

        //обработка выбора элемента списка методов для грантов
        private void grantsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pathToFile = FilesHandler.GetFilePath(1, grantsComboBox.SelectedIndex);
            ShowHintText(pathToFile);
        }

        //обработка выбора элемента списка методов для заказчиков
        private void customersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pathToFile = FilesHandler.GetFilePath(2, customersComboBox.SelectedIndex);
            ShowHintText(pathToFile);
        }

        //обработка выбора элемента списка методов для поставщиков
        private void suppliersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pathToFile = FilesHandler.GetFilePath(3, suppliersComboBox.SelectedIndex);
            ShowHintText(pathToFile);
        }

        //обработка переключения вкладок
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pathToFile = "";
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    pathToFile = FilesHandler.GetFilePath(0, contractsComboBox.SelectedIndex);
                    break;
                case 1:
                    pathToFile = FilesHandler.GetFilePath(1, grantsComboBox.SelectedIndex);
                    break;
                case 2:
                    pathToFile = FilesHandler.GetFilePath(2, customersComboBox.SelectedIndex);
                    break;
                case 3:
                    pathToFile = FilesHandler.GetFilePath(3, suppliersComboBox.SelectedIndex);
                    break;
            }
            ShowHintText(pathToFile);
        }

        //выполнение запроса к API
        private void executeButton_Click(object sender, EventArgs e)
        {
            //вызываемый метод API
            string apiMethod = "";
            //параметры запроса
            string prms = "";
            //получаемый ответ
            string response = "";
            //выбор метода API в зависимости от выбранных вкладки и элемента списка
            switch(tabControl.SelectedIndex)
            {
                //контракты
                case 0:
                    apiMethod = "contracts/";
                    //добавление get, search или select
                    apiMethod = apiMethod + GetMethodType(contractsComboBox.SelectedIndex);
                    //получение параметров
                    prms = GetParams(contractsTextBox.Text);
                    break;
                //гранты
                case 1:
                    apiMethod = "grants/";
                    apiMethod = apiMethod + GetMethodType(grantsComboBox.SelectedIndex);
                    prms = GetParams(grantsTextBox.Text);
                    break;
                //заказчики
                case 2:
                    apiMethod = "customers/";
                    apiMethod = apiMethod + GetMethodType(customersComboBox.SelectedIndex);
                    prms = GetParams(customersTextBox.Text);
                    break;
                //поставщики
                case 3:
                    apiMethod = "suppliers/";
                    apiMethod = apiMethod + GetMethodType(suppliersComboBox.SelectedIndex);
                    prms = GetParams(suppliersTextBox.Text);
                    break;
                //статистика
                case 4:
                    apiMethod = "db_info/statistics/";
                    prms = "?info=all";
                    break;
            }

            //выполнение запроса
            response = Client.GetResponse(apiMethod, prms);

            //проверка результата запроса
            if (!response.Contains("Произошла ошибка"))
            {
                //выполнение сохранения результата
                FilesHandler.SaveFile(response);
            }
            else
            {
                //вывод сообщения об ошибке
                hintTextBox.Text = response;
            }
        }

        //get, search или select в зависимости от выбранного элемента списка
        private string GetMethodType(int index)
        {
            string result = "";
            if (index == 0)
                result = "get/";
            else if (index == 1)
                result = "search/";
            else result = "select/";
            return result;
        }

        //получение параметров запроса
        private string GetParams(string textbox)
        {
            if (textbox == "")
                return textbox;
            //проверка, был ли введен знак вопроса перед списком параметров
            if (textbox[0] == '?')
                return textbox;
            else return "?" + textbox;
        }
    }
}