﻿using DiscordBot_Core;
using Xunit;

namespace DiscordBotCore.xUnit.Test
{
    public class UtilityTests
    {
        [Fact]
        public void MyFirstTest()
        {
              const int expected = 5;

              var actual = Utilities.MyUtility(expected);

              Assert.Equal(expected, actual);                  
        }
    }
 
}
