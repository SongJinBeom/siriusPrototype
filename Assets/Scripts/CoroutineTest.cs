using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    Coroutine coroutine1;
    private IEnumerator coroutine2;
    // Start is called before the first frame update
    void Start()
    {
        coroutine1 = StartCoroutine(LoopA());
        coroutine2 = LoopB();
        StartCoroutine(coroutine2);
        Stop();
    }

    #region Loop
    IEnumerator LoopA()
    {
        for(int i = 0; i < 100; i++)
        {
            print("i의 값 = " + i);
            yield return new WaitForSeconds(1f);
        }
    }
    IEnumerator LoopB()
    {
        for (int x = 0; x < 100; x++)
        {
            print("x의 값 = " + x);
            yield return new WaitForSeconds(1f);
        }
    }
    IEnumerator Stop()
    {
        yield return new WaitForSeconds(2f);
        StopCoroutine(coroutine1);

    }
    #endregion Loop
    // Update is called once per frame
    void Update()
    {
        
    }
}
