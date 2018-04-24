using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetspeakApp.Models;
using LeetspeakApp;
using System.Collections.Generic;
using System;

namespace LeetspeakApp.Tests
{
  [TestClass]
  public class LeetspeakTests : IDisposable
  {
    [TestMethod]
    public void Translate_ReturnEChange_String()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak("me");

    Assert.AreEqual("m3", testLeetSpeak.Translate());
    }

    [TestMethod]
    public void Translate_ReturnIChange_String()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak("if");

      Assert.AreEqual("1f", testLeetSpeak.Translate());
    }

    [TestMethod]
    public void Translate_ReturnOChange_String()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak("you");

      Assert.AreEqual("y0u", testLeetSpeak.Translate());
    }

    [TestMethod]
    public void Translate_ReturnTChange_String()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak("hello there");

      Assert.AreEqual("h3ll0 7h3r3", testLeetSpeak.Translate());
    }

    public void Dispose()
    {
      Leetspeak.ClearAll();
    }
  }
}
