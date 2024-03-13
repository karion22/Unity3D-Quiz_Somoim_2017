using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public float _nextTime;
    public float _typingTime = 0.2f;
    protected bool _skip;
    protected Coroutine _routine;

    public virtual void Start()
    {
        PlayStart();
    }

    public virtual void OnEnable()
    {
        PlayStart();
    }

    public virtual void PlayStart()
    {
        if (_routine != null)
            StopCoroutine(_routine);

        _routine = StartCoroutine(Play());
    }

    public virtual void Skip(bool isSkip)
    {
        _skip = isSkip;
    }

    public bool IsSkip()
    {
        return _skip;
    }

    public virtual void SetTypingTime(float inTime) { }

    protected virtual IEnumerator Play() { yield return null; }
}
