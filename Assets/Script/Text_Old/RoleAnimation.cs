using System.Collections;
using UnityEngine;

public class RoleAnimation : TypingAnimation
{    
    public string _realName;
    public string _roleName;

    public override void Reset()
    {
        base.Reset();

        _realName = string.Empty;
        _roleName = string.Empty;
    }

    protected override IEnumerator Animate()
    {
        // Step.1
        for(int i = 0, end = _realName.Length; i < end; i++)
        {
            _sb.Append(_realName[i]);
            _text.text = _sb.ToString();

            if (_isSkip)
                yield return null;
            else
                yield return new WaitForSeconds(_typingTime);
        }

        // Step.2
        _sb.Append("_");
        _text.text = _sb.ToString();

        if (_isSkip)
            yield return null;
        else
            yield return new WaitForSeconds(_typingTime);

        // Step.3
        for (int i = 0, end = _roleName.Length; i < end; i++)
        {
            _sb.Append(_roleName[i]);
            _text.text = _sb.ToString();

            if (_isSkip)
                yield return null;
            else
                yield return new WaitForSeconds(_typingTime);
        }

        // Step.4
        _sb.Append(" ");
        _text.text = _sb.ToString();

        if (_isSkip)
            yield return null;
        else
            yield return new WaitForSeconds(_typingTime);

        _sb.Append("역");
        _text.text = _sb.ToString();

        _isDone = true;
    }
}
