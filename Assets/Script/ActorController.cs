using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorController : Controller
{
    private TextAnimationController_KK _controller;

    void OnEnable()
    {
        _controller = _question.GetComponent<TextAnimationController_KK>();
        _processType = eProcessType.Question;

        ChangeProcess(_processType);
    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            _controller.Skip(false);
            if (_processType == eProcessType.Question)
                ChangeProcess(eProcessType.Answer);
            else
                GameManager.Instance.Return();
        }

        if(Input.GetKeyUp(KeyCode.LeftArrow))
        {
            _controller.Skip(false);
            if (_processType == eProcessType.Answer)
                ChangeProcess(eProcessType.Question);
        }

        if(Input.GetKeyUp(KeyCode.UpArrow))
        {
            if (_processType == eProcessType.Question)
                _controller.Skip(true);
        }

        if(Input.GetKeyUp(KeyCode.Alpha1))
        {
            _controller.SetTypingTime(0.05f);
        }

        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            _controller.SetTypingTime(0.2f);
        }

        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            _controller.SetTypingTime(0.4f);
        }
    }    
}
