using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public enum eProcessType
    {
        Question,
        Answer
    }

    public GameObject _question;
    public GameObject _answer;

    protected eProcessType _processType;

    public void ChangeProcess(eProcessType inType)
    {
        _processType = inType;
        switch (inType)
        {
            case eProcessType.Question:
                {
                    if(_question != null)
                        _question.SetActive(true);

                    if(_answer != null)
                        _answer.SetActive(false);
                }
                break;

            case eProcessType.Answer:
                {
                    if (_question != null)
                        _question.SetActive(false);

                    if (_answer != null)
                        _answer.SetActive(true);
                }
                break;
        }
    }
}
