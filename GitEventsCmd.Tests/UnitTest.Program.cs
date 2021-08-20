using System;
using Xunit;
using FluentAssertions;

namespace GitEventsCmd.Tests
{
    public class UnitTests
    {

        [Fact]
        public void TestOne()
        {
            string inputArg="blorg";
            string expectedRet="Action:blorg";
            string retVal=GitEventsCmd.Program.SomeAction(inputArg);

            retVal.Should().Equals(expectedRet);




        }
    }
}
