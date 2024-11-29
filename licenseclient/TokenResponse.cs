using System;
using System.Collections.Generic;
using System.Text;

namespace licenseclient
{
    public class TokenResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public TokenData Data { get; set; }
    }

    public class TokenData
    {
        public string Token { get; set; }
    }

}
