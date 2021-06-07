using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.CodeDom.Compiler;

public class LSystemGenerator : MonoBehaviour
{
    public string rule = "FF+[+F-F-F]-[-F+F+F]";
    public string axiom = "F";
    public float angle;
    private string currentString;
    private Dictionary<char, string> rules = new Dictionary<char, string>();
    private Stack<Transforminfo> transformStack = new Stack<Transforminfo>();

    public float length;
    private bool isGenerating = false;
    
    // Start is called before the first frame update
    void Start()
    {
        rules.Add('F', rule);
        currentString = axiom;
        //angle = 25f;
        //length = 10f;
        StartCoroutine(GenerateLSystem());

    }

    // Update is called once per frame
    void Update()
    {       
    }

    IEnumerator GenerateLSystem()
    {
        int count = 0;
        while(count < 5)
        {
            if (!isGenerating)
            {
                isGenerating = true;
                StartCoroutine(Generate ());
            }
            else
            {
                yield return new WaitForSeconds(0.1f);
            }
        }
    }

    IEnumerator Generate ()
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

        for(int i = 0; i < stringCharacters.Length; i++)
        {
            char currentCharacter = stringCharacters[i];
            if (currentCharacter == 'F')
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
            else if (currentCharacter == '[')
            {
                Transforminfo ti = new Transforminfo();
                ti.position = transform.position;
                ti.rotation = transform.rotation;
                transformStack.Push(ti);
            }
            else if (currentCharacter == ']') 
            {
                Transforminfo ti = transformStack.Pop();
                transform.position = ti.position;
                transform.rotation = ti.rotation;
            }
        }
        isGenerating = false;
    }
}
