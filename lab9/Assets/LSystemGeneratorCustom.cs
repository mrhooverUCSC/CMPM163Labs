using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LSystemGeneratorCustom : MonoBehaviour{
    private string axiom;
    private float angle;
    private string currentString;
    private Dictionary<char, string> rules = new Dictionary<char, string>();
    private Stack<TransformInfo> transformStack = new Stack<TransformInfo>();
    private float length;
    private bool isGenerating = false;
    // Start is called before the first frame update
    void Start(){
        axiom = "ABBA";
        rules.Add('A', "A[-B+B-B]+A[-B+B-B]-B");
        rules.Add('B', "ABA");
        angle = 35;
        length = 10f;

        currentString = axiom;
        StartCoroutine(GenerateLSystemC());
    }

    IEnumerator GenerateLSystemC(){
        int count = 0;

        while (count < 5)
        {
            if (!isGenerating){
                isGenerating = true;
                StartCoroutine(GenerateC());
            }
            else
            {
                yield return new WaitForSeconds(0.1f);
            }
        }
    }

    IEnumerator GenerateC()
    {
        length = length / 2f;
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
            if (currentCharacter == 'A')
            {
                Vector3 initialPosition = transform.position;
                transform.Translate(Vector3.forward * length);
                Debug.DrawLine(initialPosition, transform.position, Color.cyan, 10000f, false);
                yield return null;
            }
            else if (currentCharacter == 'B')
            {
                Vector3 initialPosition = transform.position;
                transform.Translate(Vector3.forward * length /3);
                Debug.DrawLine(initialPosition, transform.position, Color.cyan, 10000f, false);
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
            else if (currentCharacter == '[')
            {
                TransformInfo ti = new TransformInfo();
                ti.position = transform.position;
                ti.rotation = transform.rotation;
                transformStack.Push(ti);
            }
            else if (currentCharacter == ']')
            {
                TransformInfo ti = transformStack.Pop();
                transform.position = ti.position;
                transform.rotation = ti.rotation;
            }
        }
        isGenerating = false;
    }
}
