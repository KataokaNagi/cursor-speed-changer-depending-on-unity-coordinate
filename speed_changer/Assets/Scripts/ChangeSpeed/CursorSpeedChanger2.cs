/**
 * @note Pointer of Windows：cursor
 * @note Pointer object of Unity: pointer
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class CursorSpeedChanger2 : MonoBehaviour
{
    //private Vector3 pointerWPos;
    //private Vector3 cursorWPos;
    //private Vector3 cursorPreWPos;
    //private Vector3 cursorDeltaWPos;
    //private const float CHANGE_SPEED_RATE_OUT_OF_TARGET = 1.5f;
    //private const float CHANGE_SPEED_RATE_WITHIN_TARGET = 0.3f;
    ////private const float CHANGE_SPEED_RATE_OUT_OF_TARGET = 1.0f;
    ////private const float CHANGE_SPEED_RATE_WITHIN_TARGET = 1.0f;
    //private Vector3 INITIAL_POINTER_POS = new Vector3(40.0f, -40.0f, 0.0f);
    //private Vector3 AMOUNT_OF_FIX_POINTER_POS = new Vector3(0.11f, -0.13f, 0.0f);
    //public bool isWithinTarget;


    ////! For changing cursor pos
    //[System.Runtime.InteropServices.DllImport("user32.dll")]
    //public static extern bool SetCursorPos(int x, int y);


    //// Start is called before the first frame update
    //void Start()
    //{
    //    //StartCoroutine(Setting());
    //    NewField();
    //    //InitField();
    //    isWithinTarget = false;

    //    //cursorWPos = GetCursorWPos();
    //    //pointerWPos = INITIAL_POINTER_POS;
    //    //SetPointerWPos(pointerWPos);
    //    SetPointerWPos(GetCursorWPos());
    //    FixPointerTipPos();

    //    //InitCursorWPos();
    //    cursorPreWPos = GetCursorWPos();
    //}

    //IEnumerator Setting()
    //{
    //    while (!GameDirector.settingDone)
    //    {
    //        yield return null;
    //    }
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    //! TODO ターゲット内外でスピード変更
    //    cursorWPos = GetCursorWPos();
    //    cursorDeltaWPos = cursorWPos - cursorPreWPos;

    //    if (isWithinTarget)
    //    {
    //        TranslatePointerWPos(cursorDeltaWPos * CHANGE_SPEED_RATE_WITHIN_TARGET);
    //        Debug.Log("true");
    //    }
    //    else
    //    {
    //        TranslatePointerWPos(cursorDeltaWPos * CHANGE_SPEED_RATE_OUT_OF_TARGET);
    //        Debug.Log("false");
    //    }

    //    //InitCursorWPos();
    //    cursorPreWPos = GetCursorWPos();

    //    Debug.Log("cursorWPos : " + GetCursorWPos());
    //    Debug.Log("pointerWPos : " + GetPointerWPos());
    //    Debug.Log("cursorDeltaWPos : " + cursorDeltaWPos);
    //}

    //private void NewField()
    //{
    //    this.pointerWPos = new Vector3();
    //    this.cursorWPos = new Vector3();
    //    this.cursorPreWPos = new Vector3();
    //    this.cursorDeltaWPos = new Vector3();
    //}

    ////private void InitField()
    ////{
    ////}

    //public void InitCursorWPos()
    //{
    //    Vector3 tmp = new Vector3(transform.position.x, transform.position.y, 0.0f);
    //    SetCursorPos(1980 / 2, 1080  / 2);
    //    this.transform.position = tmp;
    //    //this.transform.position = tmp;
    //}

    //private Vector3 GetCursorWPos()
    //{
    //    Vector3 pos = Input.mousePosition;
    //    Vector3 worldPos = Camera.main.ScreenToWorldPoint(pos);
    //    worldPos.z = transform.position.z;
    //    return worldPos;

    //    //! Show
    //    //transform.position = worldPos;

    //    //! @see https://gist.github.com/am1tanaka/20c28e7c6e6eb14ed9cccb3f2dbddd57
    //    //Vector3 mpos = Input.mousePosition;
    //    //mpos.z = -Camera.main.transform.position.z;
    //    //Vector3 wpos = Camera.main.ScreenToWorldPoint(mpos);
    //    //transform.position = wpos;

    //    //! Ref from TargetBase.cs
    //    //var pos = Input.mousePosition;
    //    //var worldPos = Camera.main.ScreenToWorldPoint(pos);
    //    //worldPos.z = transform.position.z;
    //    //var distance = Vector3.Distance(transform.position, worldPos);
    //}

    //private void SetPointerWPos(Vector3 pointerWPos)
    //{
    //    //this.transform.position = pointerWPos;
    //    GameObject.Find("aero_arrow").transform.position = pointerWPos;
    //}

    //public Vector3 GetPointerWPos()
    //{
    //    Vector3 rtn = GameObject.Find("aero_arrow").transform.position;
    //    //Vector3 rtn = this.transform.position;
    //    return rtn;
    //    //return this.transform.position;
    //}

    //private void TranslatePointerWPos(Vector3 deltaWPos)
    //{
    //    //Vector3 tmp = deltaWPos;
    //    //this.transform.Translate(tmp);
    //    //GameObject.Find("aero_arrow").transform.Translate(deltaWPos);
    //    this.transform.Translate(deltaWPos);
    //    //this.transform.position += deltaWPos;
    //}

    //private void FixPointerTipPos()
    //{
    //    TranslatePointerWPos(AMOUNT_OF_FIX_POINTER_POS);
    //}

    //public void setIsWithinTarget(bool isWithinT)
    //{
    //    this.isWithinTarget = isWithinT;
    //    //if (isWithinTarget)
    //    //{
    //    //    Debug.Log("true");
    //    //}
    //    //else
    //    //{
    //    //    Debug.Log("false");
    //    //}
    //}

}
