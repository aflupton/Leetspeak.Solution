using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace LeetspeakApp.Models
{
  public class Leetspeak
  {
    private string _sentence;


    public void toLeet(string sentence)
    {
      _sentence=sentence;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public string Translate(string letter)
    {
      char[] sentenceArray = _sentence.ToCharArray();
          string result = "";
          for (int i=0; i < sentenceArray.Length; i++)
          {

              if (sentenceArray[i] == 'e')
              {
                  result += '3';
              }
              else if (sentenceArray[i]  == 'o')
              {
                  result += '0';
              }
              else if (sentenceArray[i]  == 'i')
              {
                  result += '1';
              }
              else if (sentenceArray[i]  == 's')
              {
                  result += 'z';
              }
              else if (sentenceArray[i]  == 's')
              {
                  result += 'z';
              }
              else if (sentenceArray[i] == 't')
                  result += '7';
              else
              {
                result += sentenceArray[i];
              }
          }
          return result;
      }

  }
}
