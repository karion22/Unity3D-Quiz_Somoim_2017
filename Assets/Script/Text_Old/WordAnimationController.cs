using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordAnimationController : AnimationController
{
    private List<WordAnimation> _targetList = new List<WordAnimation>();

    public override void Start()
    {
        WordAnimation[] children = GetComponentsInChildren<WordAnimation>();

        for (int i = 0, end = children.Length; i < end; i++)
        {
            children[i].SetTypingTime(_typingTime);
            _targetList.Add(children[i]);
        }

        base.Start();
    }

    public override void PlayStart()
    {
        for (int i = 0, end = _targetList.Count; i < end; i++)
            _targetList[i].Clear();

        base.PlayStart();
    }

    public override void Skip(bool isSkip)
    {
        base.Skip(isSkip);
        for (int i = 0, end = _targetList.Count; i < end; i++)
        {
            _targetList[i].IsSkip = isSkip;
        }
    }

    public override void SetTypingTime(float inTime)
    {
        for (int i = 0, end = _targetList.Count; i < end; i++)
        {
            _targetList[i].SetTypingTime(inTime);
        }
    }

    protected override IEnumerator Play()
    {
        for (int i = 0, end = _targetList.Count; i < end; i++)
        {
            _targetList[i].StartAnimation();

            if (_skip)
                yield return null;
            else
                yield return new WaitForSeconds(_nextTime);
        }
    }
}
