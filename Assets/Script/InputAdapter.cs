using UnityEngine;
using System.Collections;

public class InputAdapter : MonoBehaviour {

    public GUIText debugMessage;
    public GUIText sentence;        // タイピングゲームのお題を表示する
    public GUIText sentenceback;    // タイピングゲームのお題を表示する back

    Library.Keyboard key;
    Library.SentenceMaker sMaker;

	void Start () {
        key = new Library.Keyboard();
        sMaker = new Library.SentenceMaker();
        sentence.text = sMaker.getSentence();   //最初の問題
        sentenceback.text = sentence.text;
	}

	/// <summary>
	/// 
	/// </summary>
	void Update () {

        if (Check(sentence.text, key.getKeyDown()))
        {
            debugMessage.text = "OK";
            sentence.text = sentence.text.Substring(1, sentence.text.Length - 1);
            if (sentence.text == "") {
                sentence.text = sMaker.getSentence();
                if (sentence.text == "") {
                    debugMessage.text = "Clear!!";
                }
                sentenceback.text = sentence.text;
            }
        }
        else
        {
            if (key.getKeyDown() != "") { 
                debugMessage.text = "NG";
            }
        }
	}

    /// <summary>
    /// 
    /// </summary>
    /// <param name="targetText"></param>
    /// <param name="targetWord"></param>
    /// <returns></returns>
    bool Check(string targetText, string targetWord) { 
        string a;
        a = targetText.Substring(0, 1);
        if (a == targetWord)
        {
            return true;
        }
        return false;
    }

}