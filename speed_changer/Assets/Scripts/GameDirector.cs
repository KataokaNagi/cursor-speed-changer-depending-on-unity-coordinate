//using System.Collections;
//using System.Collections.Generic;
//using System;
//using UnityEngine;
//using UnityEngine.SocialPlatforms.Impl;
//using System.IO;
//using System.Globalization;

//public class GameDirector : MonoBehaviour
//{
//    public GameObject mainView;
//    public GameObject startView;
//    //private bool centerClicked = false;
//    public static int score = 0;
//    public static int pos = 0;
//    public static List<Pointing> pointingLogs = new List<Pointing>();
//    public static List<TimeCounting> countingTimes = new List<TimeCounting>();
//    private static string csvName;
//    private const string CSV_ADDR = ".\\PointingLogs\\";
//    public static bool settingDone = false;
//    DateTime TodayNow;

//    // Start is called before the first frame update
//    void Start()
//    {
//        //StartGame(); //! Change view
//        TodayNow = DateTime.Now;
//        csvName = "PointingLog";
//        csvName += "-" + TodayNow.Year.ToString();
//        csvName += "-" + TodayNow.Month.ToString();
//        csvName += "-" + TodayNow.Day.ToString();
//        csvName += "-" + TodayNow.ToLongTimeString().Replace(":", "-");
//        csvName += ".csv";

//        StartTimeScore(Time.time);

//        settingDone = true;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (Input.GetKey(KeyCode.Escape))
//        {
//            Quit();
//        }
//    }

//    public void StartGame()
//    {
//        mainView.SetActive(true);
//        startView.SetActive(false);
//    }

//    public static void AddLog(int radius, int angle, int point, float time)
//    {
//        var log = new Pointing() { radius = radius, angle = angle, point = point, time = time };
//        pointingLogs.Add(log);
//        Debug.Log("Added point: " + pointingLogs[pointingLogs.Count - 1].point);
//    }

//    public static void StartTimeScore(float startTime)
//    {
//        var log = new TimeCounting() { startTime = startTime, isCntBreakTime = false };
//        countingTimes.Add(log);
//        Debug.Log("startTime : " + countingTimes[countingTimes.Count - 1].startTime);
//    }

//    public static void StopTimeScore(float stopTime)
//    {
//        var log = new TimeCounting() { diffTime = stopTime - countingTimes[countingTimes.Count - 1].startTime, isCntBreakTime = true };
//        countingTimes.Add(log);
//        Debug.Log("diffTime : " + countingTimes[countingTimes.Count - 1].diffTime);
//    }

//    public static float GetTime()
//    {
//        return countingTimes[countingTimes.Count - 1].diffTime;
//    }

//    public static void WritePointingData()
//    {
//        //try
//        //{
//        //using (StreamWriter stream_writer = new StreamWriter(CSV_ADDR + csvName, true))
//        {
//            if (!System.IO.Directory.Exists(CSV_ADDR))
//            {
//                System.IO.Directory.CreateDirectory(CSV_ADDR);
//            }
//            if (!System.IO.File.Exists(CSV_ADDR + csvName))
//            {
//                System.IO.File.WriteAllText(CSV_ADDR + csvName, "");
//            }
//            //! true: 追記, false: 上書き
//            Debug.Log("File path : " + CSV_ADDR + csvName);
//            StreamWriter stream_writer = new StreamWriter(CSV_ADDR + csvName, false);
//            string line;

//            foreach (Pointing eachPointing in pointingLogs)
//            {
//                line = "";
//                line += eachPointing.radius.ToString() + ",";
//                line += eachPointing.angle.ToString() + ",";
//                line += eachPointing.point.ToString() + ",";
//                line += eachPointing.time.ToString() + ",";
//                line = line.Remove(line.Length - 1, 1);
//                stream_writer.WriteLine(line);
//            }
//            //stream_writer.Flush();
//            stream_writer.Close();
//            Debug.Log("Scceed in writing CSV");
//        }
//        //}
//        //catch (Exception exp)
//        //{
//        //    //Debug.LogError(exp.Message);
//        //    Debug.LogError("Error : Failed in writing CSV");
//        //    Application.Quit();
//        //}
//    }

//    public static void Quit()
//    {        
//#if UNITY_EDITOR
//        UnityEditor.EditorApplication.isPlaying = false;
//#elif UNITY_STANDALONE
//UnityEngine.Application.Quit();
//#endif
//    }
//}

//public class Pointing
//{
//    public int radius = 0;
//    public int angle = 0;
//    public int point = 0;
//    public float time = 0;
//}

//public class TimeCounting
//{
//    public float startTime = 0.0f;
//    public float diffTime = 0.0f;
//    public bool isCntBreakTime = true;

//    public void StartCntBreakTime()
//    {
//        isCntBreakTime = true;
//    }
//    public void StopCntBreakTime()
//    {
//        isCntBreakTime = false;
//    }
//}




using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using System.IO;
using System.Globalization;

public class GameDirector : MonoBehaviour
{
    public GameObject mainView;
    public GameObject startView;
    //private bool centerClicked = false;
    public static int score = 0;
    public static int pos = 0;
    public static List<Pointing> pointingLogs = new List<Pointing>();
    public static List<TimeCounting> countingTimes = new List<TimeCounting>();
    private static string csvName;
    private const string CSV_ADDR = ".\\PointingLogs\\";
    public static bool settingDone = false;
    DateTime TodayNow;

    // Start is called before the first frame update
    void Start()
    {
        //StartGame(); //! Change view
        TodayNow = DateTime.Now;
        csvName = "PointingLog";
        csvName += "-" + TodayNow.Year.ToString();
        csvName += "-" + TodayNow.Month.ToString();
        csvName += "-" + TodayNow.Day.ToString();
        csvName += "-" + TodayNow.ToLongTimeString().Replace(":", "-");
        csvName += ".csv";

        StartTimeScore(Time.time);

        settingDone = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Quit();
        }
    }

    public void StartGame()
    {
        mainView.SetActive(true);
        startView.SetActive(false);
    }

    public static void AddLog(int radius, int angle, int point, float time)
    {
        var log = new Pointing() { radius = radius, angle = angle, point = point, time = time };
        pointingLogs.Add(log);
        Debug.Log("Added point: " + pointingLogs[pointingLogs.Count - 1].point);
    }

    public static void StartTimeScore(float startTime)
    {
        var log = new TimeCounting() { startTime = startTime, isCntBreakTime = false };
        countingTimes.Add(log);
        Debug.Log("startTime : " + countingTimes[countingTimes.Count - 1].startTime);
    }

    public static void StopTimeScore(float stopTime)
    {
        var log = new TimeCounting() { diffTime = stopTime - countingTimes[countingTimes.Count - 1].startTime, isCntBreakTime = true };
        countingTimes.Add(log);
        Debug.Log("diffTime : " + countingTimes[countingTimes.Count - 1].diffTime);
    }

    public static float GetTime()
    {
        return countingTimes[countingTimes.Count - 1].diffTime;
    }

    public static void WritePointingData()
    {
        //try
        //{
        //using (StreamWriter stream_writer = new StreamWriter(CSV_ADDR + csvName, true))
        {
            if (!System.IO.Directory.Exists(CSV_ADDR))
            {
                System.IO.Directory.CreateDirectory(CSV_ADDR);
            }
            if (!System.IO.File.Exists(CSV_ADDR + csvName))
            {
                System.IO.File.WriteAllText(CSV_ADDR + csvName, "");
            }
            //! true: 追記, false: 上書き
            Debug.Log("File path : " + CSV_ADDR + csvName);
            StreamWriter stream_writer = new StreamWriter(CSV_ADDR + csvName, false);
            string line;

            foreach (Pointing eachPointing in pointingLogs)
            {
                line = "";
                line += eachPointing.radius.ToString() + ",";
                line += eachPointing.angle.ToString() + ",";
                line += eachPointing.point.ToString() + ",";
                line += eachPointing.time.ToString() + ",";
                line = line.Remove(line.Length - 1, 1);
                stream_writer.WriteLine(line);
            }
            //stream_writer.Flush();
            stream_writer.Close();
            Debug.Log("Scceed in writing CSV");
        }
        //}
        //catch (Exception exp)
        //{
        //    //Debug.LogError(exp.Message);
        //    Debug.LogError("Error : Failed in writing CSV");
        //    Application.Quit();
        //}
    }

    public static void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
    UnityEngine.Application.Quit();
#endif
    }
}

public class Pointing
{
    public int radius = 0;
    public int angle = 0;
    public int point = 0;
    public float time = 0;
}

public class TimeCounting
{
    public float startTime = 0.0f;
    public float diffTime = 0.0f;
    public bool isCntBreakTime = true;

    public void StartCntBreakTime()
    {
        isCntBreakTime = true;
    }
    public void StopCntBreakTime()
    {
        isCntBreakTime = false;
    }
}
