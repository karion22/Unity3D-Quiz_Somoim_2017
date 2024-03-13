using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefixFixController : AnimationController
{
    private List<PrefixFix> _targetList = new List<PrefixFix>();

    public override void Start()
    {
        PrefixFix[] children = GetComponentsInChildren<PrefixFix>();

        for (int i = 0, end = children.Length; i < end; i++)
        {
            _targetList.Add(children[i]);
        }

        base.Start();
    }

    public override void PlayStart()
    {
        base.PlayStart();

        _skip = false;
    }

    public override void Skip(bool isSkip)
    {
        base.Skip(isSkip);

        for (int i = 0, end = _targetList.Count; i < end; i++)
        {
            _targetList[i].IsDone = isSkip;
        }
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
