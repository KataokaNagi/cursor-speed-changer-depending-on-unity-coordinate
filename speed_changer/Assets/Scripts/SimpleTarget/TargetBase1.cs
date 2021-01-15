using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.Runtime.ConstrainedExecution;

public class TargetBase1 : MonoBehaviour
{
    //public int score;
    //public bool isCenter = false;
    //public bool isDummy = false;
    //private float startTime, diffTime;

    //public AudioClip clickSE;
    //AudioSource audioSource;
    ////SpriteRenderer spriteRenderer;

    ////! distance = radius
    ////private const float ANGLE_GAP = 45.0f;
    ////private const float DISTNC_GAP = 80.0f;
    //private const int ANGLE_GAP = 45;
    //private const int DISTNC_GAP = 80;
    //const int DISTNC_NUM = 4;
    //const int ANGLE_NUM = 8;
    //bool[] hasUsedAngle = new bool[ANGLE_NUM];
    //bool[] hasUsedDistnc = new bool[DISTNC_NUM];
    //float tmpDistnc;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    StartCoroutine(Setting());
    //}

    //IEnumerator Setting()
    //{
    //    audioSource = GetComponent<AudioSource>();
    //    audioSource.clip = clickSE;

    //    while (!GameDirector.settingDone)
    //    {
    //        yield return null;
    //    }
    //    if (isCenter)
    //    {
    //    }
    //    else if (!isDummy)
    //    {
    //        //spriteRenderer = GetComponent<SpriteRenderer>;
    //        InitHasUsedAngle();
    //        InitHasUsedDistnc();
    //        SetUnusedRandAngle(0);
    //        SetUnusedRandDistnc();
    //    }
    //    else
    //    {
    //        Invoke("DelayChangePos", 0.1f);
    //    }
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        if (!isDummy)
    //        {
    //            var pos = Input.mousePosition;
    //            var worldPos = Camera.main.ScreenToWorldPoint(pos);
    //            worldPos.z = transform.position.z;
    //            var distance = Vector3.Distance(transform.position, worldPos);
    //            //var RectTransformUtility.WorldToScreenPoint(Camera.main, target.position);

    //            //! センター周辺のグレーを押すとエラー
    //            //if (isCenter && distance < 0.235f)
    //            if (isCenter)
    //            {
    //                if (distance < 0.5f)
    //                {
    //                    GameDirector.StartTimeScore(Time.time);
    //                    //audioSource.PlayOneShot(clickSE);
    //                    audioSource.Play();
    //                    Debug.Log("Distance from Center : " + distance);
    //                }
    //            }

    //            //! Outer not dummy
    //            else
    //            {
    //                Debug.Log("Distance from Outer : " + distance);
    //                if (distance < 0.075f)
    //                {
    //                    doSomethingWhenClickedOuter(3);
    //                }
    //                else if (distance < 0.15f)
    //                {
    //                    doSomethingWhenClickedOuter(2);
    //                }
    //                else if (distance < 0.235f)
    //                {
    //                    doSomethingWhenClickedOuter(1);
    //                }
    //                else if (distance < 0.5f)
    //                {
    //                    doSomethingWhenClickedOuter(0);
    //                }
    //                else
    //                {
    //                    //! ここに書くとcenterを押したときに反応してしまう
    //                    //GameDirector.AddLog((int)transform.position.x, (int)transform.parent.rotation.eulerAngles.z, 0, GameDirector.getTime());
    //                }
    //            }

    //            //! isDummy
    //        }
    //        else
    //        {
    //            //! After Red Outer
    //            Invoke("DelayChangePos", 0.1f);
    //        }
    //    }
    //}

    //private void doSomethingWhenClickedOuter(int point)
    //{
    //    GameDirector.StopTimeScore(Time.time);
    //    audioSource.PlayOneShot(clickSE);
    //    //this.GetComponent<SpriteRenderer>().color = new Color(0.9f, 0.3f, 0.3f, 1);
    //    GameDirector.AddLog((int)transform.localPosition.x, (int)transform.parent.parent.rotation.eulerAngles.z, point, GameDirector.GetTime());
    //    SetUnusedRandAngle(point); //! 8回実行後にSetUnusedRandDistnc()を実行する機能あり
    //}

    //private void InitHasUsedAngle()
    //{
    //    int i;
    //    for (i = 0; i < ANGLE_NUM; ++i)
    //    {
    //        hasUsedAngle[i] = false;
    //    }

    //}
    //private void InitHasUsedDistnc()
    //{
    //    int i;
    //    for (i = 0; i < DISTNC_NUM; ++i)
    //    {
    //        hasUsedDistnc[i] = false;
    //    }
    //}

    //private void SetUnusedRandAngle(int point)
    //{
    //    //var angleCandList = new List<float>();
    //    //float tmpAngle;
    //    var angleCandList = new List<int>();
    //    int i;
    //    int tmpIdx;
    //    int tmpAngle;

    //    for (i = 0; i < ANGLE_NUM; ++i)
    //    {
    //        if (!hasUsedAngle[i])
    //        {
    //            angleCandList.Add(ANGLE_GAP * i);
    //        }
    //    }

    //    if (angleCandList == null || angleCandList.Count == 0)
    //    {
    //        Debug.Log("Finish: All angle completed");
    //        //! TODO: next radius
    //        InitHasUsedAngle();
    //        GameDirector.WritePointingData(); //! debug
    //        SetUnusedRandDistnc();
    //    }
    //    else
    //    {
    //        tmpIdx = UnityEngine.Random.Range(0, angleCandList.Count);
    //        tmpAngle = angleCandList[tmpIdx];
    //        //transform.parent.parent.localEulerAngles = new Vector3(0.0f, 0.0f, tmpAngle);
    //        transform.parent.parent.localEulerAngles = new Vector3(0.0f, 0.0f, (float)tmpAngle);

    //        Debug.Log("tmpIdx: " + tmpIdx);
    //        Debug.Log("tmpAngle: " + tmpAngle);

    //        //if (point != 0)
    //        {
    //            hasUsedAngle[tmpAngle / ANGLE_GAP] = true;
    //        }
    //    }
    //}

    ////! 終了処理以外はAngleと同様
    //private void SetUnusedRandDistnc()
    //{
    //    //var dCandList = new List<float>();
    //    var dCandList = new List<int>();
    //    int i;

    //    for (i = 0; i < DISTNC_NUM; ++i)
    //    {
    //        if (!hasUsedDistnc[i])
    //        {
    //            dCandList.Add(DISTNC_GAP * (i + 1));
    //        }
    //    }

    //    if (dCandList == null || dCandList.Count == 0)
    //    {
    //        Debug.Log("Finish: All radius completed");
    //        GameDirector.WritePointingData();
    //        GameDirector.Quit();
    //    }
    //    else
    //    {
    //        tmpDistnc = dCandList[UnityEngine.Random.Range(0, dCandList.Count)];
    //        transform.localPosition = new Vector3((float)tmpDistnc, 0.0f, 0.0f);
    //        hasUsedDistnc[(int)(tmpDistnc / DISTNC_GAP) - 1] = true; //! 範囲外参照に注意
    //    }
    //}

    //private void DelayChangePos()
    //{
    //    transform.localPosition = GameObject.Find("TargetOuterRed0").transform.localPosition;
    //}
}
