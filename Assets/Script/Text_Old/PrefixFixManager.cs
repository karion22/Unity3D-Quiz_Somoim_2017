using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefixFixManager : Controller
{
    private PrefixFixController _controller;

    void OnEnable()
    {
        _controller = _question.GetComponent<PrefixFixController>();
        _processType = eProcessType.Question;

        ChangeProcess(_processType);
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            if (_controller.IsSkip())
                GameManager.Instance.Return();
            else
                _controller.Skip(true);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            _controller.Skip(false);
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            _controller.Skip(true);
        }
    }
}
