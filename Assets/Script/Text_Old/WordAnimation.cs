using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class WordAnimation : MonoBehaviour
{
    private Text _text;
    public string _str;
    private float _typingTime = 0.2f;

    public bool IsDone { get; private set; }
    public bool IsSkip { get; set; }

    private StringBuilder _sb = new StringBuilder();
    private Coroutine _routine;

    public void Awake()
    {
        _text = GetComponent<Text>();
        IsDone = false;
    }

    public void SetTypingTime(float inTime)
    {
        _typingTime = inTime;
    }

    public void Clear()
    {
        _sb.Clear();
        _text.text = "";
    }

    public void StartAnimation()
    {
        IsDone = false;
        if (_routine != null)
            StopCoroutine(_routine);

        _routine = StartCoroutine(AnimateTyping(_str, _typingTime));
    }

    private IEnumerator AnimateTyping(string inStr, float inTime)
    {
        for (int i = 0, end = inStr.Length; i < end; i++)
        {
            _sb.Append(inStr[i]);
            _text.text = _sb.ToString();

            if (IsSkip)
                yield return null;
            else
                yield return new WaitForSeconds(inTime);
        }

        IsDone = true;
    }
}
