using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class TextAnimation : MonoBehaviour
{
    public enum eTextType
    {
        Consonant,      // 자음 고정
        WordAnimation,  // 단어 움직이기
        RoleName,       // 배역
        Sentence,       // 문장
    }

    protected Text _text;

    protected eTextType _type;

    protected Vector3 _position;
    protected Quaternion _rotation;

    protected bool _isDone;
    protected bool _isSkip;

    protected StringBuilder _sb = new StringBuilder();
    protected Coroutine _routine;

    protected virtual void Awake()
    {
        _text = GetComponent<Text>();
        _isSkip = false;
        _isDone = false;

        _position = transform.position;
        _rotation = transform.rotation;
    }

    public virtual void Reset()
    {
        _sb.Clear();
        if (_text != null)
            _text.text = "";

        transform.position = _position;
        transform.rotation = _rotation;

        _isSkip = false;
        _isDone = false;
    }

    public virtual void StartAnimation()
    {
        _isDone = false;

        if (_routine != null)
            StopCoroutine(_routine);

        _routine = StartCoroutine(Animate());
    }

    protected virtual IEnumerator Animate()
    {
        yield return null;
    }
}
