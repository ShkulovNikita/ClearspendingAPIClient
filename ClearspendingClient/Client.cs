using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ClearspendingClient
{
    class Client
    {
        //постоянная часть URL
        private const string URL = "http://openapi.clearspending.ru/restapi/v3/";

        //выполнение запроса к API
        static public string GetResponse(string type, string parameters)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL + type);

            //добавление заголовка с указанием принимаемого формата - JSON
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            //получение ответа от API
            HttpResponseMessage response = client.GetAsync(parameters).Result;

            //ответ успешно получен
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result;
            }
            //произошла ошибка
            else
            {
                return "Произошла ошибка\r\n" + response.StatusCode.ToString() + ": " + response.ReasonPhrase;
            }
        }
    }
}