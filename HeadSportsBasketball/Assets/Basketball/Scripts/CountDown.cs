using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class CountDown : MonoBehaviour
{
    public float time = 5;
    public TMP_Text timeText;
    // Start is called before the first frame update

    private void OnEnable()
    {
        time = 5;
        timeText.text = time.ToString();
        StartCoroutine(Count());
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Count()
    {
        while(time>0)
        {
            yield return new WaitForSeconds(1);
            time--;
            timeText.text = time.ToString();

        }
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }
}
