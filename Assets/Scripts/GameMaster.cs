using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour
{
    [SerializeField]
    Card[] cards;

    [SerializeField]
    Card target;

    void Start()
    {
        ChoosePatterns();
    }

    void ChoosePatterns()
    {
        foreach (var c in cards)
            c.ChangePattern(Random.Range(0, 6));

        target.ChangePattern(cards[Random.Range(0, 3)].PatternIndex);
    }

    bool CheckMatch(int index)
    {
        var ti = target.PatternIndex;

        if (cards[index].PatternIndex != ti) return false;

        var v = Camera.main.transform.InverseTransformDirection(target.transform.forward);
        v.z = 0;
        v = v.normalized;

        var d = Vector3.Dot(v, Vector3.up);

        Debug.Log(d);

        if (ti == 0 || ti == 1)
            return d > 0.7f || d < -0.7f || (d < 0.3f && d > -0.3f);
        else if (ti == 2 || ti == 3)
            return d > 0.7f || d < -0.7f;
        else
            return d > 0.7f;
    }

    void TouchCard(int index)
    {
        Debug.Log(CheckMatch(index));
        ChoosePatterns();
    }
}
