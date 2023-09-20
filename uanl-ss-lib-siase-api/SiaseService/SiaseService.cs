using System.Net;
using System.Net.Http.Headers;
using System.Text.Json;

namespace uanl_ss_lib_siase_api.SiaseService
{
    public class SiaseService
    {
        public string user { get; set; }
        public string password { get; set; }
        private string strToken { get; set; }
        private bool flag { get; set; }

        public SiaseService(string user, string password) { 
            this.user = user;
            this.password = password;
        }

        public async Task<string> SSGenerateSessionToken()
        {

            strToken = String.Empty;
            try
            {
                var baseAddress = new Uri("https://bumbleb.uber.space/siaseApi/api/");

                using (var httpClient = new HttpClient { BaseAddress = baseAddress })
                {
                    using (var content = new StringContent("{\"user\": \"" + user + "\",  \"password\": \"" + password + "\"}", System.Text.Encoding.Default, "application/json"))
                    {
                        using (var response = await httpClient.PostAsync("user", content))
                        {

                            System.Diagnostics.Debug.WriteLine(response.StatusCode);

                            HttpStatusCode code = response.StatusCode;

                            if (code == HttpStatusCode.OK) {

                                string responseData = await response.Content.ReadAsStringAsync();
                                System.Diagnostics.Debug.WriteLine(responseData);

                                using (JsonDocument json = JsonDocument.Parse(responseData))
                                {
                                    JsonElement root = json.RootElement;

                                    if (root.TryGetProperty("token", out JsonElement jsonElement))
                                    {
                                        strToken = jsonElement.ToString();
                                        System.Diagnostics.Debug.WriteLine(strToken);
                                    }
                                }
                            }               
                        }
                    }
                }

                return strToken;

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return strToken;               
            }
        }

        public async Task<bool> SSValidateToken(string strToken)
        {

            flag = false;

            try
            {   
                var baseAddress = new Uri("https://bumbleb.uber.space/siaseApi/api/");

                using (var httpClient = new HttpClient { BaseAddress = baseAddress })
                {

                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", strToken);

                    using (var response = await httpClient.GetAsync("user"))
                    {

                        string responseData = await response.Content.ReadAsStringAsync();

                        System.Diagnostics.Debug.WriteLine(response.StatusCode);

                        HttpStatusCode code = response.StatusCode;

                        if (code == HttpStatusCode.OK)
                        {
                            flag = true;
                        }

                        else
                        {
                            flag = false;
                        }
                    }
                }

                return flag;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return flag;
            }

        }

    }
}
