using UnityEngine;
using System;
using System.Collections;
using KBEngine;

public class clientapp : UnityKBEMain 
{
    public clientapp()
    {
        KBELog.Init(new UnityLogProvider());

        // domainMapping.Add("127.0.0.1","kbe.com");
        // domainMapping.Add("192.168.1.3","kbe.com");
        // domainMapping.Add("192.168.36.128","wss.kbelab.com");
        //
        // portMapping.Add(20013,443);
        // portMapping.Add(20015,444);
    }
}
