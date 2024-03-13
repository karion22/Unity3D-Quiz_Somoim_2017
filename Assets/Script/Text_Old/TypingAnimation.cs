using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypingAnimation : TextAnimation
{
    protected float _typingTime = 0.2f;

    public virtual void SetTypingTime(float inTime)
    {
        _typingTime = inTime;
    }
}
