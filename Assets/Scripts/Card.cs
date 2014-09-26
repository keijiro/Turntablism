using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour
{
    [SerializeField]
    Texture[] patterns;

    public int PatternIndex {
        get { return patternIndex; }
    }

    int patternIndex;

    public void ChangePattern(int index)
    {
        patternIndex = index;
        renderer.material.mainTexture = patterns[index];
    }
}
