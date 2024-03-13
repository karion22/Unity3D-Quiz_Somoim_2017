using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefixAnimationController : AnimationController
{
    private List<PrefixAnimation> _targetList = new List<PrefixAnimation>();

    public override void Start()
    {
        PrefixAnimation[] children = GetComponentsInChildren<PrefixAnimation>();

        for(int i = 0, end = children.Length; i < end; i++)
        {
            _targetList.Add(children[i]);
        }

        base.Start();
    }

    public override void PlayStart()
    {
        base.PlayStart();
    }

    public override void Skip(bool isSkip)
    {
        base.Skip(isSkip);

        /*
        for (int i = 0, end = _targetList.Count; i < end; i++)
        {
            _targetList[i].IsDone = isSkip;
        }
        */
    }

    protected override IEnumerator Play()
    {
        for (int i = 0, end = _targetList.Count; i < end; i++)
        {
            _targetList[i].StartAnimation();
        }
        yield return null;
    }
}
