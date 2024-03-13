using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SoundController : Controller
{
    private VideoPlayer _videoPlayer;

    private bool _showCamera;
    private bool _isComplete;

    public void Awake()
    {
        _showCamera = false;
        _videoPlayer = GetComponentInChildren<VideoPlayer>();
    }

    public void OnEnable()
    {
        CancelInvoke();
        _showCamera = false;
        _videoPlayer.targetCamera = null;
        _isComplete = false;
        
        if (_question != null)
            _question.SetActive(true);

        if (_answer != null)
            _answer.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            if (_isComplete)
                GameManager.Instance.Return();

            if (_showCamera == false)
            {
                _showCamera = true;
                _videoPlayer.targetCamera = Camera.main;

                if (_question != null)
                    _question.SetActive(true);

                if (_answer != null)
                    _answer.SetActive(true);

                Invoke("Hide", 2.5f);
                _isComplete = true;
            }
        }
    }

    private void Hide()
    {
        if (_answer != null)
            _answer.SetActive(false);
    }
}
