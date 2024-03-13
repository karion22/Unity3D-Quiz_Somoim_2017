using System.Collections;
using UnityEngine;

public class PrefixAnimation : TextAnimation
{
    /*
protected override IEnumerator Animate()
{
    float posTimer = 0.0f;
    float rotTimer = 0.0f;
    float delayPosTime = 0.0f;
    float delayRotTime = 0.0f;
    IsDone = false;
    bool initPos = false;
    bool initRot = false;
    Vector3 prevPos = Vector3.zero;
    Vector3 destPos = Vector3.zero;
    Quaternion prevRot = Quaternion.identity;
    Quaternion destRot = Quaternion.identity;

    transform.position = new Vector2(Random.Range(48.0f, Screen.width - 48.0f), Random.Range(48.0f, Screen.height - 48.0f));
    transform.rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, Random.Range(-180.0f, 180.0f)));

    while (IsDone == false)
    {
        if(initPos == false)
        {
            initPos = true;
            posTimer = 0.0f;
            delayPosTime = Random.Range(1.0f, 3.0f);
            prevPos = transform.position;
            destPos = new Vector2(Random.Range(48.0f, Screen.width - 48.0f), Random.Range(48.0f, Screen.height - 48.0f));
        }

        posTimer += Time.deltaTime;
        if(posTimer >= delayPosTime)
            initPos = false;
        else
            transform.position = Vector3.Lerp(prevPos, destPos, posTimer / delayPosTime);

        if(initRot == false)
        {
            initRot = true;
            rotTimer = 0.0f;
            delayRotTime = Random.Range(1.0f, 5.0f);
            prevRot = transform.rotation;
            destRot = Quaternion.Euler(new Vector3(0.0f, 0.0f, Random.Range(-180.0f, 180.0f)));
        }

        rotTimer += Time.deltaTime;
        if (rotTimer >= delayRotTime)
            initRot = false;
        else
            transform.rotation = Quaternion.Lerp(prevRot, destRot, rotTimer / delayRotTime);

        yield return null;
    }

    float timer = 0.0f;
    prevPos = transform.position;
    destPos = _position;
    prevRot = transform.rotation;
    destRot = _rotation;

    while(timer < 1.0f)
    {
        timer += Time.deltaTime;
        transform.position = Vector3.Lerp(prevPos, destPos, timer);
        transform.rotation = Quaternion.Lerp(prevRot, destRot, timer);
        yield return null;
    }

    transform.position = destPos;
    transform.rotation = destRot;
    yield return null;

    IsDone = true;
}
*/
}
