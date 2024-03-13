using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosterAnimation : MonoBehaviour
{
    private RectTransform _rt;
    private RectTransform _childRt;
    private Coroutine _routine;

    private bool isComplete = false;
    public bool IsDone { get; set; }

    public void Awake()
    {
        _rt = GetComponent<RectTransform>();

        Image image = GetComponentInChildren<Image>();
        if (image != null)
            _childRt = image.gameObject.GetComponent<RectTransform>();
    }

    public void OnEnable()
    {
        isComplete = false;
        StartAnimation();
    }

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            if (isComplete)
                GameManager.Instance.Return();
            IsDone = true;
        }

    }

    public void StartAnimation()
    {
        if (_routine != null)
            StopCoroutine(_routine);

        _routine = StartCoroutine(AnimateFunc());
    }

    private IEnumerator AnimateFunc()
    {
        while (IsDone == false)
            yield return null;

        float timer = 0.0f;
        Vector2 prevPos = _rt.sizeDelta;
        Vector2 destPos = new Vector2(2048.0f, 2048.0f);

        Vector2 prevImgPos = _childRt.anchoredPosition;
        Vector2 destImgPos = Vector2.zero;
        while (timer < 1.0f)
        {
            timer += Time.deltaTime;
            _rt.sizeDelta = Vector2.Lerp(prevPos, destPos, timer);
            _childRt.anchoredPosition = Vector2.Lerp(prevImgPos, destImgPos, timer);
            yield return null;
        }

        _rt.sizeDelta = destPos;
        _childRt.anchoredPosition = destImgPos;
        yield return null;

        IsDone = true;
        isComplete = true;
    }
}
