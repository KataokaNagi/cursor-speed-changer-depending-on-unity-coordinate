//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.Serialization;
//using UnityEngine;
//using UnityEngine.UI;

//public class CntTxt : MonoBehaviour
//{
//    private const int BREAK_NUM = 5;

//    GameObject obj;
//    Text txt;
//    public AudioClip cntSE;
//    AudioSource audioSource;

//    private TimeCounting countingTime;
//    private bool isFirstCntLoop;
//    private bool[] hasCntedTime;
//    private int breakTime;
//    private float startCntTime;

//    // Start is called before the first frame update
//    void Start()
//    {
//        obj = GameObject.Find("CntTxt");
//        this.txt = obj.GetComponent<Text>();
//        audioSource = GetComponent<AudioSource>();
//        InitBool();
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        //! Exception
//        if (GameDirector.countingTimes.Count != 0)
//        {
//            //! Get latest isCntBreakTime
//            countingTime = GameDirector.countingTimes[GameDirector.countingTimes.Count - 1];

//            if (countingTime.isCntBreakTime)
//            {
//                if (isFirstCntLoop)
//                {
//                    isFirstCntLoop = false;
//                    startCntTime = Time.time;
//                }
//                breakTime = BREAK_NUM - (int)(Time.time - startCntTime) % (BREAK_NUM + 1); //! in [0,5]

//                if (!hasCntedTime[breakTime])
//                {
//                    this.txt.text = "休憩 " + breakTime + " / " + BREAK_NUM + "s";
//                    hasCntedTime[breakTime] = true;

//                    switch (breakTime)
//                    {
//                        case BREAK_NUM:
//                            this.txt.color = new Color(0.0f, 0.75f, 0.0f, 1.0f);
//                            break;
//                        case 3:
//                            audioSource.PlayOneShot(cntSE);
//                            break;
//                        case 0:
//                            this.txt.color = new Color(0.9f, 0.3f, 0.3f, 1.0f);
//                            countingTime.StopCntBreakTime();
//                            InitBool();
//                            break;
//                        default:
//                            break;
//                    }
//                }

//                //case 0:
//                //    if (hasBeenPreviousNum[])
//                //    {
//                //        countingTime.StopCntBreakTime();
//                //        hasBeenPreviousNum[] = false;
//                //        break;
//                //    }
//                //    this.txt.text = "休憩 5 / 5s";
//                //    break;
//                //case 1:
//                //    this.txt.text = "休憩 4 / 5s";
//                //    break;
//                //case 2:
//                //    this.txt.text = "休憩 3 / 5s";
//                //    break;
//                //case 3:
//                //    this.txt.text = "休憩 2 / 5s";
//                //    break;
//                //case 4:
//                //    this.txt.text = "休憩 1 / 5s";
//                //    break;
//                //default:
//                //    this.txt.text = "休憩 0 / 5s";
//                //    hasBeenPreviousNum[] = true;
//                //    break;
//            }
//            else
//            {
//                this.txt.text = "休憩 0 / 5s";
//            }
//        }

//    }

//    private void InitBool()
//    {
//        hasCntedTime = new bool[BREAK_NUM + 1];

//        isFirstCntLoop = true;
//        for (int i = 0; i < BREAK_NUM + 1; ++i)
//        {
//            hasCntedTime[i] = false;
//        }
//    }


//    //private void CountText()
//    //{

//    //}

//    //public void StartCnt()
//    //{
//    //    this.isCnting = true;
//    //    this.startTime = Time.time;
//    //}

//    //public void StopCnt()
//    //{
//    //    this.isCnting = false;
//    //}

//    //public bool GetIsCnting()
//    //{
//    //    return this.isCnting;
//    //}
//}




using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class CntTxt : MonoBehaviour
{
    private const int BREAK_NUM = 5;

    GameObject obj;
    Text txt;
    public AudioClip cntSE;
    AudioSource audioSource;

    private TimeCounting countingTime;
    private bool isFirstCntLoop;
    private bool[] hasCntedTime;
    private int breakTime;
    private float startCntTime;

    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("CntTxt");
        this.txt = obj.GetComponent<Text>();
        audioSource = GetComponent<AudioSource>();
        InitBool();
    }

    // Update is called once per frame
    void Update()
    {
        //! Exception
        if (GameDirector.countingTimes.Count != 0)
        {
            //! Get latest isCntBreakTime
            countingTime = GameDirector.countingTimes[GameDirector.countingTimes.Count - 1];

            if (countingTime.isCntBreakTime)
            {
                if (isFirstCntLoop)
                {
                    isFirstCntLoop = false;
                    startCntTime = Time.time;
                }
                breakTime = BREAK_NUM - (int)(Time.time - startCntTime) % (BREAK_NUM + 1); //! in [0,5]

                if (!hasCntedTime[breakTime])
                {
                    this.txt.text = "休憩 " + breakTime + " / " + BREAK_NUM + "s";
                    hasCntedTime[breakTime] = true;

                    switch (breakTime)
                    {
                        case BREAK_NUM:
                            this.txt.color = new Color(0.0f, 0.75f, 0.0f, 1.0f);
                            break;
                        case 3:
                            audioSource.PlayOneShot(cntSE);
                            break;
                        case 0:
                            this.txt.color = new Color(0.9f, 0.3f, 0.3f, 1.0f);
                            countingTime.StopCntBreakTime();
                            InitBool();
                            break;
                        default:
                            break;
                    }
                }

                //case 0:
                //    if (hasBeenPreviousNum[])
                //    {
                //        countingTime.StopCntBreakTime();
                //        hasBeenPreviousNum[] = false;
                //        break;
                //    }
                //    this.txt.text = "休憩 5 / 5s";
                //    break;
                //case 1:
                //    this.txt.text = "休憩 4 / 5s";
                //    break;
                //case 2:
                //    this.txt.text = "休憩 3 / 5s";
                //    break;
                //case 3:
                //    this.txt.text = "休憩 2 / 5s";
                //    break;
                //case 4:
                //    this.txt.text = "休憩 1 / 5s";
                //    break;
                //default:
                //    this.txt.text = "休憩 0 / 5s";
                //    hasBeenPreviousNum[] = true;
                //    break;
            }
            else
            {
                this.txt.text = "休憩 0 / 5s";
            }
        }

    }

    private void InitBool()
    {
        hasCntedTime = new bool[BREAK_NUM + 1];

        isFirstCntLoop = true;
        for (int i = 0; i < BREAK_NUM + 1; ++i)
        {
            hasCntedTime[i] = false;
        }
    }


    //private void CountText()
    //{

    //}

    //public void StartCnt()
    //{
    //    this.isCnting = true;
    //    this.startTime = Time.time;
    //}

    //public void StopCnt()
    //{
    //    this.isCnting = false;
    //}

    //public bool GetIsCnting()
    //{
    //    return this.isCnting;
    //}
}
