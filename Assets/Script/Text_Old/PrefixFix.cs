using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefixFix : MonoBehaviour
{
    private Vector3 _position;
    private Quaternion _rotation;
    private Text _text;

    public string _start;
    public string _result;

    public bool IsDone { get; set; }

    private Coroutine _routine;

    public void Awake()
    {
        _position = transform.position;
        _rotation = transform.rotation;

        _text = GetComponent<Text>();
    }

    public void StartAnimation()
    {
        _text.text = _start;
        if (_routine != null)
            StopCoroutine(_routine);

        _routine = StartCoroutine(AnimateFunc());
    }

    private IEnumerator AnimateFunc()
    {
        IsDone = false;
        Vector3 prevPos = Vector3.zero;
        Vector3 destPos = Vector3.zero;
        Quaternion prevRot = Quaternion.identity;
        Quaternion destRot = Quaternion.identity;

        //transform.position = new Vector2(Random.Range(128.0f, Screen.width - 128.0f), Random.Range(128.0f, Screen.height - 128.0f));
        //transform.rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, Random.Range(-45.0f, 45.0f)));

        while (IsDone == false)
        {
            yield return null;
        }

        /*
        float timer = 0.0f;
        prevPos = transform.position;
        destPos = _position;
        prevRot = transform.rotation;
        destRot = _rotation;

        while (timer < 1.0f)
        {
            timer += Time.deltaTime;
            transform.position = Vector3.Lerp(prevPos, destPos, timer);
            transform.rotation = Quaternion.Lerp(prevRot, destRot, timer);
            yield return null;
        }

        transform.position = destPos;
        transform.rotation = destRot;
        yield return null;
        */

        _text.text = _result;

        IsDone = true;
    }
}
