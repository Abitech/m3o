using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using CodeBetter.Json;

namespace com.abitech.rfid
{
    class RfidJson
    {
        public static RpcResponse<string> Deserialize(string s)
        {
            var response = new RpcResponse<string>();
            var match = new Regex("{\"result\":\"?(.*?)\"?,\"error\":(.*?)}").Match(s);
            if (match.Success)
            {
                if (match.Groups[1].Value == "null")
                    response.result = null;
                else
                    response.result = match.Groups[1].Value;

				if (match.Groups[2].Value == "null")
					response.error = null;
				else
				{
					try
					{
						response.error = ((ResponseCode)Int32.Parse(match.Groups[2].Value)).ToString();
					}
					catch (Exception e)
					{
						response.result = e.Message;
						response.error = ResponseCode.InternalServerError.ToString();
						return response;
					}
				}
            }
            else
            {
                response.result = null;
				response.error = ResponseCode.CorruptedResponse.ToString();
            }

            return response;
        }
    }
}
