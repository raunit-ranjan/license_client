﻿using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace licenseclient
{
  
    public class LicenseClient
    {
        private const string username = "licenseservice";
        private const string password = "v(Y3=j}]:]40";
        private const string ApiBaseUrl = "http://localhost:3300/client";

        private async Task<string> GetToken(string productCode, string clientCode, string username, string password)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var url = $"{ApiBaseUrl}/getToken";

                    // Constructing the authentication data
                    var authData = new
                    {
                        productCode,
                        clientCode,
                        username,
                        password
                    };

                    // Serializing the data to JSON and sending the POST request
                    var jsonContent = JsonConvert.SerializeObject(authData);
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(url, content);

                    // Ensure the response is successful
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(result);

                        return tokenResponse?.Data?.Token; // Returning the token from the nested Data object
                    }
                    else
                    {
                        // If the response is not successful, throw an error with the response content
                        var error = await response.Content.ReadAsStringAsync();
                        throw new HttpRequestException($"Error: {response.StatusCode}, Details: {error}");
                    }
                }
                catch (Exception ex)
                {
                    // Optionally log the exception
                    throw new Exception("An error occurred while fetching the token.", ex);
                }
            }
        }



        public async Task<string> ActivateLicense(string productCode, string clientCode, string licenseKey, string macID)
        {
            var token = await GetToken(productCode, clientCode, username, password); 

            
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var requestData = new
                {                    
                    licenseKey,
                    macID
                };

                var jsonContent = JsonConvert.SerializeObject(requestData);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var url = $"{ApiBaseUrl}/activateLicense";
                var response = await client.PostAsync(url, content);

                if (!response.IsSuccessStatusCode)
                {
                    var error = await response.Content.ReadAsStringAsync();
                    throw new HttpRequestException(error);
                }

                return await response.Content.ReadAsStringAsync(); 
            }
        }

        public async Task<string> ValidateLicense(string productCode, string clientCode, string macID)
        {
            var token = await GetToken(productCode, clientCode, username, password); 


            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var requestData = new
                {                    
                    macID
                };

                var jsonContent = JsonConvert.SerializeObject(requestData);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var url = $"{ApiBaseUrl}/validateLicense";
                var response = await client.PostAsync(url, content);

                if (!response.IsSuccessStatusCode)
                {
                    var error = await response.Content.ReadAsStringAsync();
                    throw new HttpRequestException(error);
                }

                return await response.Content.ReadAsStringAsync(); 
            }
        }

        public async Task<string> TransferLicense(string productCode, string clientCode, string licenseKey, string macID)
        {
            var token = await GetToken(productCode, clientCode, username, password); 


            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var requestData = new
                {
                    licenseKey,
                    macID
                };

                var jsonContent = JsonConvert.SerializeObject(requestData);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var url = $"{ApiBaseUrl}/transferLicense";
                var response = await client.PostAsync(url, content);

                if (!response.IsSuccessStatusCode)
                {
                    var error = await response.Content.ReadAsStringAsync();
                    throw new HttpRequestException(error);
                }

                return await response.Content.ReadAsStringAsync(); 
            }
        }

       
    }
}
