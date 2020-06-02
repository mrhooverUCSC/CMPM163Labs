using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//LSystemGeneratorTriangle, T for Triangle
public class LSystemGeneratorTriangle : MonoBehaviour{
    private string axiom;
    private float angle;
    private string currentString;
    private Dictionary<char, string> rules = new Dictionary<char, string>();
    private Stack<TransformInfo> transformStack = new Stack<TransformInfo>();
    private float length;
    private bool isGenerating = false;
    // Start is called before the first frame update
    void Start(){
        axiom = "F-G-G";
        rules.Add('F', "F-G+F+G-F");
        rules.Add('G', "GG");
        angle = 120f;
        length = 10f;

        currentString = axiom;
        StartCoroutine(GenerateLSystemT());
    }

    IEnumerator GenerateLSystemT(){
        while (true)
        {
            if (!isGenerating){
                isGenerating = true;
                StartCoroutine(GenerateT());
            }
            else
            {
                yield return new WaitForSeconds(0.1f);
            }
        }
    }

    IEnumerator GenerateT()
    {
        length = length / 2;
        string newString = "";
        char[] stringCharacters = currentString.ToCharArray();
        for (int i = 0; i < stringCharacters.Length; i++)
        {
            char currentCharacter = stringCharacters[i];
            if (rules.ContainsKey(currentCharacter))
            {
                newString += rules[currentCharacter];
            }
            else
            {
                newString += currentCharacter.ToString();
            }
        }

        currentString = newString;
        Debug.Log(currentString);
        stringCharacters = currentString.ToCharArray();

        for (int i = 0; i < stringCharacters.Length; i++)
        {
            char currentCharacter = stringCharacters[i];
            if (currentCharacter == 'F' || currentCharacter == 'G')
            {
                Vector3 initialPosition = transform.position;
                transform.Translate(Vector3.forward * length);
                Debug.DrawLine(initialPosition, transform.position, Color.white, 10000f, false);
                yield return null;
            }
            else if (currentCharacter == '+')
            {
                transform.Rotate(Vector3.up * angle);
            }
            else if (currentCharacter == '-')
            {
                transform.Rotate(Vector3.up * -angle);
            }
        }
        isGenerating = false;
    }
}
