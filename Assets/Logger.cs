using System;
using System.Collections.Generic;
using UnityEngine;

public class Logger : MonoBehaviour
{
    public List<Log> logs;
    // Start is called before the first frame update
    void Start()
    {
        logs = new List<Log>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Add(string text) {
        Log log = new Log { dateTime = DateTime.Now, text = text };
        logs.Add(log);
    }
}

public class Log
{
     public DateTime dateTime { get; set; }
     public string text { get; set; }

}
