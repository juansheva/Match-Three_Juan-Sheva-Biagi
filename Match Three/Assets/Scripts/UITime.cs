using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITime : MonoBehaviour
{
    public Text time;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        time.text = GetTimeString(TimeManager.Instance.GetRemainingTime() + 1);
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    private string GetTimeString(float timeRemaining)
    {
        int minute = Mathf.FloorToInt(timeRemaining / 60);
        int second = Mathf.FloorToInt(timeRemaining % 60);

        return string.Format("{0} : {1}", minute.ToString(), second.ToString());
    }
}