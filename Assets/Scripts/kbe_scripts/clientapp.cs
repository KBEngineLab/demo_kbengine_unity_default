using UnityEngine;
using System;
using System.Collections;
using KBEngine;

public class clientapp : UnityKBEMain 
{
    public clientapp()
    {
        KBELog.Init(new UnityLogProvider());
    }
}
