using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Karion.Text
{
    public enum eTextType
    {
        Consonant,
        Word,
        Role,
    }

    [System.Flags]
    public enum eAnimationType
    {
        None = 0x00,
        Position = 0x01,
        Rotation = 0x02,

        MAX = 0xff,
    }

    public enum eEffectType
    {
        None,
        WordByWord,
        FadeCenter,
        SweepSide,
        BlowLikeDust,
    }

    public class mTextAnimation : MonoBehaviour
    {
        private eTextType _textType;
        private eAnimationType _animationType;
        private eEffectType _effectType;

        private Coroutine _processRoutine;
    }
}
