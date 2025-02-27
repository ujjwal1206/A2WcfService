﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace A2WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(UriTemplate= "/secretnumber?x={x}&y={y}", ResponseFormat =WebMessageFormat.Json)]
        int SecretNumber(int x, int y);

        [OperationContract]
        [WebGet(UriTemplate = "/checknumber?x={x}&y={y}", ResponseFormat = WebMessageFormat.Json)]
        string CheckNumber(int x, int y);
    }


   
}
