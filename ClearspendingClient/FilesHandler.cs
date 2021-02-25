using System;
using System.IO;
using System.Windows.Forms;

namespace ClearspendingClient
{
    class FilesHandler
    {
        //получение пути к файлу по выбранным вкладке и элементу списка
        static public string GetFilePath(int tab, int index)
        {
            string path = "";
            //первая часть пути зависит от выбранной вкладки
            switch (tab)
            {
                case 0:
                    path = @"info_files\contracts\";
                    break;
                case 1:
                    path = @"info_files\grants\";
                    break;
                case 2:
                    path = @"info_files\customers\";
                    break;
                case 3:
                    path = @"info_files\suppliers\";
                    break;
            }
            //вторая часть пути - от выбранного элемента выпадающего списка
            switch (index)
            {
                case 0:
                    path = path + "get.txt";
                    break;
                case 1:
                    path = path + "search.txt";
                    break;
                case 2:
                    path = path + "select.txt";
                    break;
            }
            //возвращение результата
            try
            {
                return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
            }
            catch (Exception e)
            {
                return "Произошла ошибка: " + e.Message;
            }
        }

        //получение текста из файла
        static public string ReadFile (string path)
        {
            string result = "";

            try
            {
                //построчное чтение из файла
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        result = result + line + "\r\n";
                    }
                }
            }
            catch (Exception e)
            {
                result = "Произошла ошибка: " + e.Message;
            }

            return result;
        }

        //сохранение файла в проводнике
        static public void SaveFile(string text)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.AddExtension = true;
            saveFileDialog.Filter = "(*.json)|*.json";
            saveFileDialog.Title = "Сохранение результата запроса";
            //открытие диалогового окна для сохранения файла
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            //сохранение текста в файл
            string filename = saveFileDialog.FileName;
            File.WriteAllText(filename, text);
        }
    }
}